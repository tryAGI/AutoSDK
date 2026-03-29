//HintName: G.Models.EditImageGetReferenceBox.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: subjectBox
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetReferenceBox
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="originalImage")]
        OriginalImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subjectBox")]
        SubjectBox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetReferenceBoxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetReferenceBox value)
        {
            return value switch
            {
                EditImageGetReferenceBox.OriginalImage => "originalImage",
                EditImageGetReferenceBox.SubjectBox => "subjectBox",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetReferenceBox? ToEnum(string value)
        {
            return value switch
            {
                "originalImage" => EditImageGetReferenceBox.OriginalImage,
                "subjectBox" => EditImageGetReferenceBox.SubjectBox,
                _ => null,
            };
        }
    }
}