//HintName: G.Models.EditImageGetHorizontalAlignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetHorizontalAlignment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="center")]
        Center,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="left")]
        Left,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="right")]
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetHorizontalAlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetHorizontalAlignment value)
        {
            return value switch
            {
                EditImageGetHorizontalAlignment.Center => "center",
                EditImageGetHorizontalAlignment.Left => "left",
                EditImageGetHorizontalAlignment.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetHorizontalAlignment? ToEnum(string value)
        {
            return value switch
            {
                "center" => EditImageGetHorizontalAlignment.Center,
                "left" => EditImageGetHorizontalAlignment.Left,
                "right" => EditImageGetHorizontalAlignment.Right,
                _ => null,
            };
        }
    }
}