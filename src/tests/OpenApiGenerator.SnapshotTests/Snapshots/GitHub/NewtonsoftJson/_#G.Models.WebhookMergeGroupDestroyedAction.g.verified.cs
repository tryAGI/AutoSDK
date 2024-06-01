//HintName: G.Models.WebhookMergeGroupDestroyedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookMergeGroupDestroyedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="destroyed")]
        Destroyed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMergeGroupDestroyedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMergeGroupDestroyedAction value)
        {
            return value switch
            {
                WebhookMergeGroupDestroyedAction.Destroyed => "destroyed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMergeGroupDestroyedAction ToEnum(string value)
        {
            return value switch
            {
                "destroyed" => WebhookMergeGroupDestroyedAction.Destroyed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}