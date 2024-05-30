//HintName: G.Models.ListRunStepsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum ListRunStepsOrder
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

    public static class ListRunStepsOrderExtensions
    {
        public static string ToValueString(this ListRunStepsOrder value)
        {
            return value switch
            {
                ListRunStepsOrder.Asc => "asc",
                ListRunStepsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListRunStepsOrder ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListRunStepsOrder.Asc,
                "desc" => ListRunStepsOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListRunStepsOrder ToEnum(int value)
        {
            return value switch
            {
                0 => ListRunStepsOrder.Asc,
                1 => ListRunStepsOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}