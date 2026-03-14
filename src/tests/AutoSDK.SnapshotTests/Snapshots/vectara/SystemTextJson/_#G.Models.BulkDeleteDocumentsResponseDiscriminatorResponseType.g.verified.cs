//HintName: G.Models.BulkDeleteDocumentsResponseDiscriminatorResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkDeleteDocumentsResponseDiscriminatorResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Async,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkDeleteDocumentsResponseDiscriminatorResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkDeleteDocumentsResponseDiscriminatorResponseType value)
        {
            return value switch
            {
                BulkDeleteDocumentsResponseDiscriminatorResponseType.Async => "async",
                BulkDeleteDocumentsResponseDiscriminatorResponseType.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkDeleteDocumentsResponseDiscriminatorResponseType? ToEnum(string value)
        {
            return value switch
            {
                "async" => BulkDeleteDocumentsResponseDiscriminatorResponseType.Async,
                "success" => BulkDeleteDocumentsResponseDiscriminatorResponseType.Success,
                _ => null,
            };
        }
    }
}