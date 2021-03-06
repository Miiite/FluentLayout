// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class PickerExtensions
    {


        public static TBindable WithPickerSelectedIndexChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Picker
        {
            self.SelectedIndexChanged += handlerAction;

            return self;
        }

        public static TBindable ClearPickerSelectedIndexChangedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "SelectedIndexChanged");

            return self;
        }

        public static TBindable WithPickerChildrenReorderedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Picker
        {
            self.ChildrenReordered += handlerAction;

            return self;
        }

        public static TBindable ClearPickerChildrenReorderedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildrenReordered");

            return self;
        }

        public static TBindable WithPickerFocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : Picker
        {
            self.Focused += handlerAction;

            return self;
        }

        public static TBindable ClearPickerFocusedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Focused");

            return self;
        }

        public static TBindable WithPickerMeasureInvalidatedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Picker
        {
            self.MeasureInvalidated += handlerAction;

            return self;
        }

        public static TBindable ClearPickerMeasureInvalidatedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "MeasureInvalidated");

            return self;
        }

        public static TBindable WithPickerSizeChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Picker
        {
            self.SizeChanged += handlerAction;

            return self;
        }

        public static TBindable ClearPickerSizeChangedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "SizeChanged");

            return self;
        }

        public static TBindable WithPickerUnfocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : Picker
        {
            self.Unfocused += handlerAction;

            return self;
        }

        public static TBindable ClearPickerUnfocusedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Unfocused");

            return self;
        }

        public static TBindable WithPickerBatchCommittedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.Internals.EventArg<Xamarin.Forms.VisualElement>> handlerAction) where TBindable : Picker
        {
            self.BatchCommitted += handlerAction;

            return self;
        }

        public static TBindable ClearPickerBatchCommittedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "BatchCommitted");

            return self;
        }

        public static TBindable WithPickerFocusChangeRequestedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.VisualElement.FocusRequestArgs> handlerAction) where TBindable : Picker
        {
            self.FocusChangeRequested += handlerAction;

            return self;
        }

        public static TBindable ClearPickerFocusChangeRequestedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "FocusChangeRequested");

            return self;
        }

        public static TBindable WithPickerChildAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : Picker
        {
            self.ChildAdded += handlerAction;

            return self;
        }

        public static TBindable ClearPickerChildAddedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildAdded");

            return self;
        }

        public static TBindable WithPickerChildRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : Picker
        {
            self.ChildRemoved += handlerAction;

            return self;
        }

        public static TBindable ClearPickerChildRemovedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildRemoved");

            return self;
        }

        public static TBindable WithPickerDescendantAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : Picker
        {
            self.DescendantAdded += handlerAction;

            return self;
        }

        public static TBindable ClearPickerDescendantAddedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "DescendantAdded");

            return self;
        }

        public static TBindable WithPickerDescendantRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : Picker
        {
            self.DescendantRemoved += handlerAction;

            return self;
        }

        public static TBindable ClearPickerDescendantRemovedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "DescendantRemoved");

            return self;
        }

        public static TBindable WithPickerPlatformSetEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Picker
        {
            self.PlatformSet += handlerAction;

            return self;
        }

        public static TBindable ClearPickerPlatformSetHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PlatformSet");

            return self;
        }

        public static TBindable WithPickerPropertyChangedEvent<TBindable>(this TBindable self,
            System.ComponentModel.PropertyChangedEventHandler handlerAction) where TBindable : Picker
        {
            self.PropertyChanged += handlerAction;

            return self;
        }

        public static TBindable ClearPickerPropertyChangedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PropertyChanged");

            return self;
        }

        public static TBindable WithPickerBindingContextChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Picker
        {
            self.BindingContextChanged += handlerAction;

            return self;
        }

        public static TBindable ClearPickerBindingContextChangedHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "BindingContextChanged");

            return self;
        }

        public static TBindable WithPickerPropertyChangingEvent<TBindable>(this TBindable self,
            Xamarin.Forms.PropertyChangingEventHandler handlerAction) where TBindable : Picker
        {
            self.PropertyChanging += handlerAction;

            return self;
        }

        public static TBindable ClearPickerPropertyChangingHandlers<TBindable>(this TBindable self) where TBindable : Picker
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PropertyChanging");

            return self;
        }
        
        public static TBindable BindTextColorPicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Picker
                => self.Bind(Picker.TextColorProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindTitlePicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Picker
                => self.Bind(Picker.TitleProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindSelectedIndexPicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Picker
                => self.Bind(Picker.SelectedIndexProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindItemsSourcePicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Picker
                => self.Bind(Picker.ItemsSourceProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindSelectedItemPicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Picker
                => self.Bind(Picker.SelectedItemProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindFontFamilyPicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Picker
                => self.Bind(Picker.FontFamilyProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindFontSizePicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Picker
                => self.Bind(Picker.FontSizeProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindFontAttributesPicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Picker
                => self.Bind(Picker.FontAttributesProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}