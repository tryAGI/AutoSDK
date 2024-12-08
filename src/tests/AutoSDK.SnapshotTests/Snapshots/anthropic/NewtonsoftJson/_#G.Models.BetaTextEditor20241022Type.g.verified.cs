//HintName: G.Models.BetaTextEditor20241022Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaTextEditor20241022Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_editor_20241022")]
        TextEditor20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTextEditor20241022TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextEditor20241022Type value)
        {
            return value switch
            {
                BetaTextEditor20241022Type.TextEditor20241022 => "text_editor_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextEditor20241022Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_20241022" => BetaTextEditor20241022Type.TextEditor20241022,
                _ => null,
            };
        }
    }
}