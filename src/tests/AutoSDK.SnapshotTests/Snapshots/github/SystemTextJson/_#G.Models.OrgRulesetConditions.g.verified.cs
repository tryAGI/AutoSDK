//HintName: G.Models.OrgRulesetConditions.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Conditions for an organization ruleset.<br/>
    /// The branch and tag rulesets conditions object should contain both `repository_name` and `ref_name` properties, or both `repository_id` and `ref_name` properties, or both `repository_property` and `ref_name` properties.<br/>
    /// The push rulesets conditions object does not require the `ref_name` property.
    /// </summary>
    public readonly partial struct OrgRulesetConditions : global::System.IEquatable<OrgRulesetConditions>
    {
        /// <summary>
        /// Conditions to target repositories by name and refs by name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>? RepositoryNameAndRefName { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>? RepositoryNameAndRefName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryNameAndRefName))]
#endif
        public bool IsRepositoryNameAndRefName => RepositoryNameAndRefName != null;

        /// <summary>
        /// Conditions to target repositories by id and refs by name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>? RepositoryIdAndRefName { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>? RepositoryIdAndRefName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryIdAndRefName))]
#endif
        public bool IsRepositoryIdAndRefName => RepositoryIdAndRefName != null;

        /// <summary>
        /// Conditions to target repositories by property and refs by name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>? RepositoryPropertyAndRefName { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>? RepositoryPropertyAndRefName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryPropertyAndRefName))]
#endif
        public bool IsRepositoryPropertyAndRefName => RepositoryPropertyAndRefName != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRulesetConditions(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget> value) => new OrgRulesetConditions((global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>?(OrgRulesetConditions @this) => @this.RepositoryNameAndRefName;

        /// <summary>
        /// 
        /// </summary>
        public OrgRulesetConditions(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>? value)
        {
            RepositoryNameAndRefName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRulesetConditions(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget> value) => new OrgRulesetConditions((global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>?(OrgRulesetConditions @this) => @this.RepositoryIdAndRefName;

        /// <summary>
        /// 
        /// </summary>
        public OrgRulesetConditions(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>? value)
        {
            RepositoryIdAndRefName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRulesetConditions(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget> value) => new OrgRulesetConditions((global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>?(OrgRulesetConditions @this) => @this.RepositoryPropertyAndRefName;

        /// <summary>
        /// 
        /// </summary>
        public OrgRulesetConditions(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>? value)
        {
            RepositoryPropertyAndRefName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OrgRulesetConditions(
            global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>? repositoryNameAndRefName,
            global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>? repositoryIdAndRefName,
            global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>? repositoryPropertyAndRefName
            )
        {
            RepositoryNameAndRefName = repositoryNameAndRefName;
            RepositoryIdAndRefName = repositoryIdAndRefName;
            RepositoryPropertyAndRefName = repositoryPropertyAndRefName;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RepositoryPropertyAndRefName as object ??
            RepositoryIdAndRefName as object ??
            RepositoryNameAndRefName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RepositoryNameAndRefName?.ToString() ??
            RepositoryIdAndRefName?.ToString() ??
            RepositoryPropertyAndRefName?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRepositoryNameAndRefName && !IsRepositoryIdAndRefName && !IsRepositoryPropertyAndRefName || !IsRepositoryNameAndRefName && IsRepositoryIdAndRefName && !IsRepositoryPropertyAndRefName || !IsRepositoryNameAndRefName && !IsRepositoryIdAndRefName && IsRepositoryPropertyAndRefName;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>?, TResult>? repositoryNameAndRefName = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>?, TResult>? repositoryIdAndRefName = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>?, TResult>? repositoryPropertyAndRefName = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRepositoryNameAndRefName && repositoryNameAndRefName != null)
            {
                return repositoryNameAndRefName(RepositoryNameAndRefName!);
            }
            else if (IsRepositoryIdAndRefName && repositoryIdAndRefName != null)
            {
                return repositoryIdAndRefName(RepositoryIdAndRefName!);
            }
            else if (IsRepositoryPropertyAndRefName && repositoryPropertyAndRefName != null)
            {
                return repositoryPropertyAndRefName(RepositoryPropertyAndRefName!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>?>? repositoryNameAndRefName = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>?>? repositoryIdAndRefName = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>?>? repositoryPropertyAndRefName = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRepositoryNameAndRefName)
            {
                repositoryNameAndRefName?.Invoke(RepositoryNameAndRefName!);
            }
            else if (IsRepositoryIdAndRefName)
            {
                repositoryIdAndRefName?.Invoke(RepositoryIdAndRefName!);
            }
            else if (IsRepositoryPropertyAndRefName)
            {
                repositoryPropertyAndRefName?.Invoke(RepositoryPropertyAndRefName!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RepositoryNameAndRefName,
                typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>),
                RepositoryIdAndRefName,
                typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>),
                RepositoryPropertyAndRefName,
                typeof(global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(OrgRulesetConditions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryNameTarget>?>.Default.Equals(RepositoryNameAndRefName, other.RepositoryNameAndRefName) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryIdTarget>?>.Default.Equals(RepositoryIdAndRefName, other.RepositoryIdAndRefName) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRulesetConditions, global::G.RepositoryRulesetConditionsRepositoryPropertyTarget>?>.Default.Equals(RepositoryPropertyAndRefName, other.RepositoryPropertyAndRefName) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrgRulesetConditions obj1, OrgRulesetConditions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrgRulesetConditions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrgRulesetConditions obj1, OrgRulesetConditions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrgRulesetConditions o && Equals(o);
        }
    }
}
