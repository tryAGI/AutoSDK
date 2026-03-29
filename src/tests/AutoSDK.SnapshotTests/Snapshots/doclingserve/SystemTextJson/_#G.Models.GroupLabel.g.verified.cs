//HintName: G.Models.GroupLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GroupLabel.
    /// </summary>
    public enum GroupLabel
    {
        /// <summary>
        /// 
        /// </summary>
        Chapter,
        /// <summary>
        /// 
        /// </summary>
        CommentSection,
        /// <summary>
        /// 
        /// </summary>
        FormArea,
        /// <summary>
        /// 
        /// </summary>
        Inline,
        /// <summary>
        /// 
        /// </summary>
        KeyValueArea,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        OrderedList,
        /// <summary>
        /// 
        /// </summary>
        PictureArea,
        /// <summary>
        /// 
        /// </summary>
        Section,
        /// <summary>
        /// 
        /// </summary>
        Sheet,
        /// <summary>
        /// 
        /// </summary>
        Slide,
        /// <summary>
        /// 
        /// </summary>
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