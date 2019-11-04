namespace DocConverter.Infrastructure.Logger
{
    /// <summary>
    /// Event codes
    /// </summary>
    public class LoggingEvents
    {
        #region Create entities

        /// <summary>
        /// Creating new template
        /// </summary>
        public const int CreateTemplate = 1001;

        #endregion

        #region Update entities

        /// <summary>
        /// Update template
        /// </summary>
        public const int UpdateTemplate = 1101;

        #endregion

        #region Delete entities

        /// <summary>
        /// Delete template
        /// </summary>
        public const int DeleteTemplate = 1201;

        #endregion
    }
}
