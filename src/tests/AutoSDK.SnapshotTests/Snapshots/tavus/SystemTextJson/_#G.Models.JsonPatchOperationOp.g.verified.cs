//HintName: G.Models.JsonPatchOperationOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum JsonPatchOperationOp
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Copy,
        /// <summary>
        /// 
        /// </summary>
        Move,
        /// <summary>
        /// 
        /// </summary>
        Remove,
        /// <summary>
        /// 
        /// </summary>
        Replace,
        /// <summary>
        /// 
        /// </summary>
        Test,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JsonPatchOperationOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JsonPatchOperationOp value)
        {
            return value switch
            {
                JsonPatchOperationOp.Add => "add",
                JsonPatchOperationOp.Copy => "copy",
                JsonPatchOperationOp.Move => "move",
                JsonPatchOperationOp.Remove => "remove",
                JsonPatchOperationOp.Replace => "replace",
                JsonPatchOperationOp.Test => "test",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JsonPatchOperationOp? ToEnum(string value)
        {
            return value switch
            {
                "add" => JsonPatchOperationOp.Add,
                "copy" => JsonPatchOperationOp.Copy,
                "move" => JsonPatchOperationOp.Move,
                "remove" => JsonPatchOperationOp.Remove,
                "replace" => JsonPatchOperationOp.Replace,
                "test" => JsonPatchOperationOp.Test,
                _ => null,
            };
        }
    }
}