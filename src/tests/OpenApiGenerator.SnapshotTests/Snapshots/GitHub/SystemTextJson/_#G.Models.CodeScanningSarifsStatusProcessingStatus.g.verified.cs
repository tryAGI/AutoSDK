//HintName: G.Models.CodeScanningSarifsStatusProcessingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `pending` files have not yet been processed, while `complete` means results from the SARIF have been stored. `failed` files have either not been processed at all, or could only be partially processed.
    /// </summary>
    public abstract class CodeScanningSarifsStatusProcessingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Pending = "pending";
        /// <summary>
        /// 
        /// </summary>
        public const string Complete = "complete";
        /// <summary>
        /// 
        /// </summary>
        public const string Failed = "failed";
    }
}