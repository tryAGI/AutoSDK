//HintName: G.Models.CreateTaskRequestVariant7Animation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTaskRequestVariant7Animation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="preset:dive")]
        Preset_dive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="preset:run")]
        Preset_run,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="preset:walk")]
        Preset_walk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant7AnimationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant7Animation value)
        {
            return value switch
            {
                CreateTaskRequestVariant7Animation.Preset_dive => "preset:dive",
                CreateTaskRequestVariant7Animation.Preset_run => "preset:run",
                CreateTaskRequestVariant7Animation.Preset_walk => "preset:walk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant7Animation? ToEnum(string value)
        {
            return value switch
            {
                "preset:dive" => CreateTaskRequestVariant7Animation.Preset_dive,
                "preset:run" => CreateTaskRequestVariant7Animation.Preset_run,
                "preset:walk" => CreateTaskRequestVariant7Animation.Preset_walk,
                _ => null,
            };
        }
    }
}