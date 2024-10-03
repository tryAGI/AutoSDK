//HintName: G.Models.PatchDocumentActionOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The operation to be performed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchDocumentActionOp
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
    public static class PatchDocumentActionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchDocumentActionOp value)
        {
            return value switch
            {
                PatchDocumentActionOp.Add => "add",
                PatchDocumentActionOp.Remove => "remove",
                PatchDocumentActionOp.Replace => "replace",
                PatchDocumentActionOp.Move => "move",
                PatchDocumentActionOp.Copy => "copy",
                PatchDocumentActionOp.Test => "test",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchDocumentActionOp? ToEnum(string value)
        {
            return value switch
            {
                "add" => PatchDocumentActionOp.Add,
                "remove" => PatchDocumentActionOp.Remove,
                "replace" => PatchDocumentActionOp.Replace,
                "move" => PatchDocumentActionOp.Move,
                "copy" => PatchDocumentActionOp.Copy,
                "test" => PatchDocumentActionOp.Test,
                _ => null,
            };
        }
    }
}