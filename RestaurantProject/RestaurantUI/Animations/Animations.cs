using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace RestaurantUI
{
    //This class helps to animate pages in specific ways
    public static class Animations
    {
        #region Storyboards
        //Slides a page in from the right
        public static async Task SlideInFromRightAsync(this Page page, float seconds)
        {
            var storyboard = new Storyboard();

            storyboard.Children.Add(SlideFromRightAnimation(seconds, page.WindowWidth, 0.9f));
            storyboard.Children.Add(FadeInAnimation(seconds));

            storyboard.Begin(page);

            page.Visibility = Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }

        //Slides a page out to the left
        public static async Task SlideOutToLeftAsync(this Page page, float seconds)
        {
            var storyboard = new Storyboard();

            storyboard.Children.Add(SlideToLeftAnimaton(seconds, page.WindowWidth, 0.9f));
            storyboard.Children.Add(FadeOutAnimation(seconds));

            storyboard.Begin(page);

            page.Visibility = Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }
        #endregion

        #region Animations
        //Adds a slide from right animation to the storyboard
        public static ThicknessAnimation SlideFromRightAnimation(float seconds, double offset, float decelerationRatio)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(offset, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };
            
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            return animation;
        }
        
        //Adds a slide to left animation to the storyboard
        public static ThicknessAnimation SlideToLeftAnimaton(float seconds, double offset, float decelerationRatio)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, offset, 0),
                DecelerationRatio = decelerationRatio
            };
            
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            return animation;
        }

        //Adds a fade in animation to the storyboard
        public static DoubleAnimation FadeInAnimation(float seconds)
        {
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1,
            };
            
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            return animation;
        }
        
        //Adds a fade out animation to the storyboard
        public static DoubleAnimation FadeOutAnimation(float seconds)
        {
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0,
            };
            
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            return animation;
        }
        #endregion
    }
}
