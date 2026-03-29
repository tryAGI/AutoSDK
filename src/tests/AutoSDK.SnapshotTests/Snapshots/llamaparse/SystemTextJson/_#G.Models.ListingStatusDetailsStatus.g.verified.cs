//HintName: G.Models.ListingStatusDetailsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the listing process<br/>
    /// Default Value: pending
    /// </summary>
    public enum ListingStatusDetailsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListingStatusDetailsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListingStatusDetailsStatus value)
        {
            return value switch
            {
                ListingStatusDetailsStatus.Completed => "completed",
                ListingStatusDetailsStatus.Failed => "failed",
                ListingStatusDetailsStatus.Pending => "pending",
                ListingStatusDetailsStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListingStatusDetailsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListingStatusDetailsStatus.Completed,
                "failed" => ListingStatusDetailsStatus.Failed,
                "pending" => ListingStatusDetailsStatus.Pending,
                "processing" => ListingStatusDetailsStatus.Processing,
                _ => null,
            };
        }
    }
}