//HintName: G.Models.IntegrationListStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntegrationListStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationListStatus value)
        {
            return value switch
            {
                IntegrationListStatus.Active => "active",
                IntegrationListStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationListStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => IntegrationListStatus.Active,
                "archived" => IntegrationListStatus.Archived,
                _ => null,
            };
        }
    }
}