// Toolkit namespace
using SimpleMvvmToolkit;
using System;

// Toolkit extension methods

namespace CalendarTest
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// Use the <strong>mvvmprop</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// </summary>
    public class MainPageViewModel : ViewModelDetailBase<MainPageViewModel, Customer>
    {
        #region Initialization and Cleanup

        // Default ctor
        public MainPageViewModel() 
        {
            // Create new customer
            Customer = new Customer()
            {
                CustomerName = "Brian",
                City = "Powell",
                CustomerId = 123
            };

            Model = Customer;
            BeginEdit();
        }
        

        #endregion

        #region Notifications

        // TODO: Add events to notify the view or obtain data from the view
        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;

        #endregion

        #region Properties

        public Customer Customer
        {
            get { return _Customer; }
             set
             {
                 _Customer = value;
                 NotifyPropertyChanged(m => m.Customer);
             }
         }
        private Customer _Customer;



        #endregion

        #region Methods

        #endregion

        #region Completion Callbacks

        // TODO: Optionally add callback methods for async calls to the service agent

        #endregion

        #region Helpers

        // Helper method to notify View of an error
        private void NotifyError(string message, Exception error)
        {
            // Notify view of an error
            Notify(ErrorNotice, new NotificationEventArgs<Exception>(message, error));
        }

        #endregion
    }



}