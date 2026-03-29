//HintName: G.Models.GroupLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GroupLabel.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GroupLabel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chapter")]
        Chapter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="comment_section")]
        CommentSection,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="form_area")]
        FormArea,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inline")]
        Inline,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="key_value_area")]
        KeyValueArea,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ordered_list")]
        OrderedList,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="picture_area")]
        PictureArea,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="section")]
        Section,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sheet")]
        Sheet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slide")]
        Slide,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unspecified")]
        Unspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupLabel value)
        {
            return value switch
            {
                GroupLabel.Chapter => "chapter",
                GroupLabel.CommentSection => "comment_section",
                GroupLabel.FormArea => "form_area",
                GroupLabel.Inline => "inline",
                GroupLabel.KeyValueArea => "key_value_area",
                GroupLabel.List => "list",
                GroupLabel.OrderedList => "ordered_list",
                GroupLabel.PictureArea => "picture_area",
                GroupLabel.Section => "section",
                GroupLabel.Sheet => "sheet",
                GroupLabel.Slide => "slide",
                GroupLabel.Unspecified => "unspecified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupLabel? ToEnum(string value)
        {
            return value switch
            {
                "chapter" => GroupLabel.Chapter,
                "comment_section" => GroupLabel.CommentSection,
                "form_area" => GroupLabel.FormArea,
                "inline" => GroupLabel.Inline,
                "key_value_area" => GroupLabel.KeyValueArea,
                "list" => GroupLabel.List,
                "ordered_list" => GroupLabel.OrderedList,
                "picture_area" => GroupLabel.PictureArea,
                "section" => GroupLabel.Section,
                "sheet" => GroupLabel.Sheet,
                "slide" => GroupLabel.Slide,
                "unspecified" => GroupLabel.Unspecified,
                _ => null,
            };
        }
    }
}