using System;
using Android.Graphics;
using Xamarin.Forms.Platform.Android;

namespace Playground.Droid.CustomRenderers
{
    public class CircularImageRenderer : ImageRenderer
    {

        protected override bool DrawChild(Canvas canvas, Android.Views.View child, long drawingTime)
        {
            var radius = Math.Min(Width, Height)/2;
            var strokeWidth = 10;
            radius -= strokeWidth/2;

            //Create path to clip
            var path = new Path();
            path.AddCircle(Width/2, Height/2, radius, Path.Direction.Ccw);
            canvas.Save();
            canvas.ClipPath(path);

            var result = base.DrawChild(canvas, child, drawingTime);
            canvas.Restore();

            // Create path for circle border
            path = new Path();
            path.AddCircle(Width/2, Height/2, radius, Path.Direction.Ccw);
            var paint = new Paint();
            paint.AntiAlias = true;
            paint.StrokeWidth = 5;
            paint.SetStyle(Paint.Style.Stroke);
            paint.Color = Color.White;
            canvas.DrawPath(path, paint);

            //Properly dispose
            paint.Dispose();
            path.Dispose();

            return result;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Image> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                if ((int)Android.OS.Build.VERSION.SdkInt < 18)
                    SetLayerType(Android.Views.LayerType.Software, null);
            }
        }
    }
}

