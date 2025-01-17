﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace ZFileComponent.Verifys
{

    public interface IMetroThumb : IInputElement
    {
        event DragStartedEventHandler DragStarted;

        event DragDeltaEventHandler DragDelta;

        event DragCompletedEventHandler DragCompleted;

        event MouseButtonEventHandler MouseDoubleClick;
    }

    public class MetroThumb: Thumb,IMetroThumb
    {
        private TouchDevice currentDevice = null;

        protected override void OnPreviewTouchDown(TouchEventArgs e)
        {

            this.ReleaseCurrentDevice();

            this.CaptureCurrentDevice(e);
        }

        protected override void OnPreviewTouchUp(TouchEventArgs e)
        {
            this.ReleaseCurrentDevice();
        }

        protected override void OnLostTouchCapture(TouchEventArgs e)
        {
            if (this.currentDevice != null)
            {
                this.CaptureCurrentDevice(e);
            }
        }

        private void ReleaseCurrentDevice()
        {
            if (this.currentDevice != null)
            {
                var temp = this.currentDevice;
                this.currentDevice = null;
                this.ReleaseTouchCapture(temp);
            }
        }

        private void CaptureCurrentDevice(TouchEventArgs e)
        {
            bool gotTouch = this.CaptureTouch(e.TouchDevice);
            if (gotTouch)
            {
                this.currentDevice = e.TouchDevice;
            }
        }
    }
}
