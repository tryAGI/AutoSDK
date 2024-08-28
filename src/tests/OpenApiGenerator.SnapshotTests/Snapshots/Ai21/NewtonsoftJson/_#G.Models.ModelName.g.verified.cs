//HintName: G.Models.ModelName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jamba-instruct")]
        JambaInstruct,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jamba-instruct-preview")]
        JambaInstructPreview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jamba-next")]
        JambaNext,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jamba-large-next")]
        JambaLargeNext,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jamba-large-next-2")]
        JambaLargeNext2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jamba-1.5-mini")]
        Jamba15Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jamba-1.5-large")]
        Jamba15Large,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelName value)
        {
            return value switch
            {
                ModelName.JambaInstruct => "jamba-instruct",
                ModelName.JambaInstructPreview => "jamba-instruct-preview",
                ModelName.JambaNext => "jamba-next",
                ModelName.JambaLargeNext => "jamba-large-next",
                ModelName.JambaLargeNext2 => "jamba-large-next-2",
                ModelName.Jamba15Mini => "jamba-1.5-mini",
                ModelName.Jamba15Large => "jamba-1.5-large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelName? ToEnum(string value)
        {
            return value switch
            {
                "jamba-instruct" => ModelName.JambaInstruct,
                "jamba-instruct-preview" => ModelName.JambaInstructPreview,
                "jamba-next" => ModelName.JambaNext,
                "jamba-large-next" => ModelName.JambaLargeNext,
                "jamba-large-next-2" => ModelName.JambaLargeNext2,
                "jamba-1.5-mini" => ModelName.Jamba15Mini,
                "jamba-1.5-large" => ModelName.Jamba15Large,
                _ => null,
            };
        }
    }
}