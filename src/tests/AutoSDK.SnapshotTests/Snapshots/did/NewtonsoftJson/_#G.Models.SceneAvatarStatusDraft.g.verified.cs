//HintName: G.Models.SceneAvatarStatusDraft.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SceneAvatarStatusDraft
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="draft")]
        Draft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SceneAvatarStatusDraftExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SceneAvatarStatusDraft value)
        {
            return value switch
            {
                SceneAvatarStatusDraft.Draft => "draft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SceneAvatarStatusDraft? ToEnum(string value)
        {
            return value switch
            {
                "draft" => SceneAvatarStatusDraft.Draft,
                _ => null,
            };
        }
    }
}