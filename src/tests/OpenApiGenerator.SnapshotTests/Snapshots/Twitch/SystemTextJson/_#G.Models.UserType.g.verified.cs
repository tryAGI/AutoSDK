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
    public abstract class UserType
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Admin = "admin";
        /// <summary>
        /// 
        /// </summary>
        public const string GlobalMod = "global_mod";
        /// <summary>
        /// 
        /// </summary>
        public const string Staff = "staff";
    }
}