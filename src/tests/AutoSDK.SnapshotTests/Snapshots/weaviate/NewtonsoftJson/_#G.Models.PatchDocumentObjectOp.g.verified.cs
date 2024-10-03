//HintName: G.Models.PatchDocumentObjectOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The operation to be performed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchDocumentObjectOp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="add")]
        Add,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="remove")]
        Remove,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="replace")]
        Replace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="move")]
        Move,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="copy")]
        Copy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="test")]
        Test,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchDocumentObjectOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchDocumentObjectOp value)
        {
            return value switch
            {
                PatchDocumentObjectOp.Add => "add",
                PatchDocumentObjectOp.Remove => "remove",
                PatchDocumentObjectOp.Replace => "replace",
                PatchDocumentObjectOp.Move => "move",
                PatchDocumentObjectOp.Copy => "copy",
                PatchDocumentObjectOp.Test => "test",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchDocumentObjectOp? ToEnum(string value)
        {
            return value switch
            {
                "add" => PatchDocumentObjectOp.Add,
                "remove" => PatchDocumentObjectOp.Remove,
                "replace" => PatchDocumentObjectOp.Replace,
                "move" => PatchDocumentObjectOp.Move,
                "copy" => PatchDocumentObjectOp.Copy,
                "test" => PatchDocumentObjectOp.Test,
                _ => null,
            };
        }
    }
}