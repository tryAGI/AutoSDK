//HintName: G.Models.BranchNodeVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the node
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BranchNodeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch")]
        Branch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BranchNodeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchNodeVariant2Type value)
        {
            return value switch
            {
                BranchNodeVariant2Type.Branch => "branch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchNodeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "branch" => BranchNodeVariant2Type.Branch,
                _ => null,
            };
        }
    }
}