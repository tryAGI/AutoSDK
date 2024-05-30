//HintName: G.Models.CreateModerationRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModerationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-moderation-latest")]
        TextModerationLatest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-moderation-stable")]
        TextModerationStable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModerationRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationRequestModel value)
        {
            return value switch
            {
                CreateModerationRequestModel.TextModerationLatest => "text-moderation-latest",
                CreateModerationRequestModel.TextModerationStable => "text-moderation-stable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationRequestModel ToEnum(string value)
        {
            return value switch
            {
                "text-moderation-latest" => CreateModerationRequestModel.TextModerationLatest,
                "text-moderation-stable" => CreateModerationRequestModel.TextModerationStable,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}