//HintName: G.Models.UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of user. Possible values are:  
    ///   
    /// * admin — Twitch administrator
    /// * global\_mod
    /// * staff — Twitch staff
    /// * "" — Normal user
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="global_mod")]
        GlobalMod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="staff")]
        Staff,
    }
}