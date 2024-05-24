//HintName: G.Models.AuthenticationTokenRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describe whether all repositories have been selected or there's a selection involved
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuthenticationTokenRepositorySelection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }
}