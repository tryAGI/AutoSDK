//HintName: G.Models.WebhooksRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describe whether all repositories have been selected or there's a selection involved
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRepositorySelection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksRepositorySelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRepositorySelection value)
        {
            return value switch
            {
                WebhooksRepositorySelection.All => "all",
                WebhooksRepositorySelection.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRepositorySelection? ToEnum(string value)
        {
            return value switch
            {
                "all" => WebhooksRepositorySelection.All,
                "selected" => WebhooksRepositorySelection.Selected,
                _ => null,
            };
        }
    }
}