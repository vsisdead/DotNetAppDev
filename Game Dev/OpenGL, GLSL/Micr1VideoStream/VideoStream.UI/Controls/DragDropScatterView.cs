﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Surface.Presentation;
using Microsoft.Surface.Presentation.Controls;
using VideoStream.UI.Events;
using SoftwareLab.Components.YouTube;

namespace VideoStream.UI.Controls
{
    /// <summary>
    /// A class that inherits ScatterView with Drag & Drop support.
    /// </summary>
    public class DragDropScatterView : ScatterView
    {
        public DragDropScatterView()
        {
            // Change Background to transparent, or Drag Drop hit test will by pass it if its Background is null.
            Background = Brushes.Transparent; 
            AllowDrop = true;

            Loaded += new RoutedEventHandler(OnLoaded);
            Unloaded += new RoutedEventHandler(OnUnloaded);
        }

        #region Public Properties

        /// <summary>
        /// Property to identify whether the ScatterViewItem can be dragged.
        /// </summary>
        public static readonly DependencyProperty AllowDragProperty = DependencyProperty.Register(
            "AllowDrag",
            typeof(bool),
            typeof(DragDropScatterView),
            new PropertyMetadata(true/*defaultValue*/));

        /// <summary>
        /// Getter of AllowDrag AttachProperty.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static bool GetAllowDrag(DependencyObject element)
        {
            if (!(element is ScatterViewItem))
            {
                throw new InvalidOperationException("AllowDragOnlyOnScatterViewItem");
            }

            return (bool)element.GetValue(AllowDragProperty);
        }

        /// <summary>
        /// Setter of AllowDrag AttachProperty.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SetAllowDrag(DependencyObject element, bool value)
        {
            if (!(element is ScatterViewItem))
            {
                throw new InvalidOperationException("AllowDragOnlyOnScatterViewItem");
            }

            element.SetValue(AllowDragProperty, value);
        }

        #endregion

        #region Private Methods

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            SurfaceDragDrop.AddDropHandler(this, OnCursorDrop);
            AddHandler(ScatterViewItem.ContainerManipulationStartedEvent, new ContainerManipulationStartedEventHandler(OnManipulationStarted));
        }

        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            SurfaceDragDrop.RemoveDropHandler(this, OnCursorDrop);
            RemoveHandler(ScatterViewItem.ContainerManipulationStartedEvent, new ContainerManipulationStartedEventHandler(OnManipulationStarted));
        }

        private void OnManipulationStarted(object sender, RoutedEventArgs args)
        {
            ScatterViewItem svi = args.OriginalSource as ScatterViewItem;
            if (svi != null && DragDropScatterView.GetAllowDrag(svi))
            {
                svi.BeginDragDrop(svi.DataContext);
            }
        }

        private void OnCursorDrop(object sender, SurfaceDragDropEventArgs args)
        {
            SurfaceDragCursor droppingCursor = args.Cursor;

            // Add dropping Item that was from another drag source.
            if (droppingCursor.CurrentTarget == this && droppingCursor.DragSource != this)
            {
                if (Items.Contains(droppingCursor.Data))
                {
                    Items.Remove(droppingCursor.Data);
                }
                if (!Items.Contains(droppingCursor.Data))
                {
                    Items.Add(droppingCursor.Data);

                    var svi = ItemContainerGenerator.ContainerFromItem(droppingCursor.Data) as ScatterViewItem;
                    if (svi != null)
                    {
                        svi.Center = droppingCursor.GetPosition(this);
                        svi.Orientation = droppingCursor.GetOrientation(this);
                        //svi.Height = droppingCursor.Visual.ActualHeight;
                        //svi.Width = droppingCursor.Visual.ActualWidth;
                        svi.MinWidth = 400;
                        svi.MinHeight = 225;
                        svi.MaxHeight = 1080;
                        svi.MaxWidth = 1920;
                        svi.Opacity = 1;
                        svi.SetRelativeZIndex(RelativeScatterViewZIndex.Topmost);

                        VideoControl viewer = new VideoControl();
         //               viewer.RemoveContent += new Events.RemoveContentHandler(RemoveContent);
                        //Viewer viewer = new Viewer();
                        
                        viewer.MinWidth = 400;
                        viewer.MinHeight = 225;
                        viewer.MaxHeight = 1080;
                        viewer.MaxWidth = 1920;
                        viewer.DataContext = droppingCursor.Data;
                        svi.Content = viewer;
                    }
                }
            }
        }

        //void RemoveContent(object sender, RemoveContentEventArgs e)
        //{
        //    IContent content = sender as IContent;
        //    if (content != null)
        //    {
        //        content.RemoveContent -= RemoveContent;
        //    }

        //    if (e.Content != null)
        //    {
        //        //e.Content.RemoveContent -= RemoveContent;
        //        if (e.Content is VideoControl)
        //        {
        //            VideoControl video = e.Content as VideoControl;
        //            if (video != null)
        //            {
        //                //video.AnimateExit();
        //                foreach (object obj in this.Items)
        //                {
        //                    var svi = ItemContainerGenerator.ContainerFromItem(obj) as ScatterViewItem;
        //                    if (svi != null)
        //                    {
        //                        SearchResultControl ctrl = svi.Content as SearchResultControl;
        //                        if (ctrl != null)
        //                        {
        //                            ctrl.EnableVideo(video.DataContext as Video);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        else if (e.Content is SearchResultControl)
        //        {

        //        }
        //    }
        //}

        #endregion
    }
}