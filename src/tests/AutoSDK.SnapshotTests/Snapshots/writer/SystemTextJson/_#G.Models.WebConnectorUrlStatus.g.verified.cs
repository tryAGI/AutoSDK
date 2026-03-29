//HintName: G.Models.WebConnectorUrlStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of web connector URL processing.
    /// </summary>
    public enum WebConnectorUrlStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebConnectorUrlStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebConnectorUrlStatus value)
        {
            return value switch
            {
                WebConnectorUrlStatus.Error => "error",
                WebConnectorUrlStatus.Success => "success",
                WebConnectorUrlStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebConnectorUrlStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => WebConnectorUrlStatus.Error,
                "success" => WebConnectorUrlStatus.Success,
                "validating" => WebConnectorUrlStatus.Validating,
                _ => null,
            };
        }
    }
}