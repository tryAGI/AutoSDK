//HintName: G.Models.GetModelsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter models by status - omit to include all statuses<br/>
    /// Example: active
    /// </summary>
    public enum GetModelsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Deprecated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsStatus value)
        {
            return value switch
            {
                GetModelsStatus.Active => "active",
                GetModelsStatus.Deprecated => "deprecated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetModelsStatus.Active,
                "deprecated" => GetModelsStatus.Deprecated,
                _ => null,
            };
        }
    }
}