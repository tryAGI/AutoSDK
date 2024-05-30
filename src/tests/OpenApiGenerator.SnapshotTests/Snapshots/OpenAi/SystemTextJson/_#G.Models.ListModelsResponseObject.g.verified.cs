//HintName: G.Models.ListModelsResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListModelsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    public static class ListModelsResponseObjectExtensions
    {
        public static string ToValueString(this ListModelsResponseObject value)
        {
            return value switch
            {
                ListModelsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListModelsResponseObject ToEnum(string value)
        {
            return value switch
            {
                "list" => ListModelsResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListModelsResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => ListModelsResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}