//HintName: G.Models.WebhookDiscussionCategoryChangedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDiscussionCategoryChangedAction
    {
        /// <summary>
        /// 
        /// </summary>
        CategoryChanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionCategoryChangedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionCategoryChangedAction value)
        {
            return value switch
            {
                WebhookDiscussionCategoryChangedAction.CategoryChanged => "category_changed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionCategoryChangedAction ToEnum(string value)
        {
            return value switch
            {
                "category_changed" => WebhookDiscussionCategoryChangedAction.CategoryChanged,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}