using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RestaurantUI
{
    //A base attached property to replace the vanilla WPF attached property
    public abstract class BaseAttachedProperty<Parent, Property> where Parent : BaseAttachedProperty<Parent, Property>, new()
    {
        #region Public Events
        
        //Fired when the value changes
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e) => { };

        #endregion

        #region Public Properties
        
        //A singleton instance of our parent class
        public static Parent Instance { get; private set; } = new Parent();

        #endregion

        #region Attached Property Definitions
        
        //The attached property for this class
        public static readonly DependencyProperty ValueProperty = DependencyProperty.RegisterAttached("Value", typeof(Property), typeof(BaseAttachedProperty<Parent, Property>), new UIPropertyMetadata(new PropertyChangedCallback(OnValuePropertyChanged)));
        
        //The callback event when the ValueProperty is changed
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Call the parent function
            Instance.OnValueChanged(d, e);

            // Call event listeners
            Instance.ValueChanged(d, e);
        }
        
        //Gets the attached property
        public static Property GetValue(DependencyObject d) => (Property)d.GetValue(ValueProperty);
        
        //Sets the attached property
        public static void SetValue(DependencyObject d, Property value) => d.SetValue(ValueProperty, value);

        #endregion

        #region Event Methods
        
        //The method that is called when any attached property of this type is changed
        public virtual void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) { }

        #endregion
    }
}
