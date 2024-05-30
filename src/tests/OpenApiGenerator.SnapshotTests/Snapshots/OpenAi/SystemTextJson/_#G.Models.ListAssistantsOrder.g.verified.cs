//HintName: G.Models.ListAssistantsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum ListAssistantsOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    public static class ListAssistantsOrderExtensions
    {
        public static string ToValueString(this ListAssistantsOrder value)
        {
            return value switch
            {
                ListAssistantsOrder.Asc => "asc",
                ListAssistantsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListAssistantsOrder ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListAssistantsOrder.Asc,
                "desc" => ListAssistantsOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListAssistantsOrder ToEnum(int value)
        {
            return value switch
            {
                0 => ListAssistantsOrder.Asc,
                1 => ListAssistantsOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}