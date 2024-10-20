namespace SimpleCalculator
{
    public static class Program
    {
        /// <summary>
        /// [STAThread] is an attribute in C# that indicates the COM 
        /// (Component Object Model) threading model for the application.
        /// 
        /// Fuctionality:
        /// - STA stands for Single Threaded Apartment, It tells the runtime that the
        ///     application will use a single-threaded apartment model for threading.
        /// - In Windows Forms or WPF applications, most UI frameworks are STA-based
        ///     because Windows UI components are not thread-saef and can only be
        ///     accessed by one thread (typically the main thread)
        /// - COM Objects, which may be used in UI components, need to run in a specific 
        ///     threading model, and STA ensures that these components behave 
        ///     correctly in the context of the UI thread.
        ///     
        /// What It's Doing:
        /// - The [STAThread] attribute is applied to the Main method to indicate that the
        ///     main thread of the application will run in a single-threaded apartment.
        /// - Without this attribute, certain UI operations or interactions with COM components
        ///     may not function properly, leading to error or undefined behaviour.
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}