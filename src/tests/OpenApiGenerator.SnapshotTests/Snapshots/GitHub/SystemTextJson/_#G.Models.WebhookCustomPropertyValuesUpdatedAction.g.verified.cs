//HintName: G.Models.WebhookCustomPropertyValuesUpdatedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCustomPropertyValuesUpdatedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCustomPropertyValuesUpdatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCustomPropertyValuesUpdatedAction value)
        {
            return value switch
            {
                WebhookCustomPropertyValuesUpdatedAction.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCustomPropertyValuesUpdatedAction ToEnum(string value)
        {
            return value switch
            {
                "updated" => WebhookCustomPropertyValuesUpdatedAction.Updated,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}