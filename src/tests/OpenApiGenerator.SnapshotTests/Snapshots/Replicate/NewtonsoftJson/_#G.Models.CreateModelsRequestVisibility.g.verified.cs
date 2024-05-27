//HintName: G.Models.CreateModelsRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelsRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
    }
}