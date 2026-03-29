//HintName: G.Models.AliasOperations.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Group of all the possible operations related to collection aliases
    /// </summary>
    public readonly partial struct AliasOperations : global::System.IEquatable<AliasOperations>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateAliasOperation? CreateOperation { get; init; }
#else
        public global::G.CreateAliasOperation? CreateOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateOperation))]
#endif
        public bool IsCreateOperation => CreateOperation != null;

        /// <summary>
        /// Delete alias if exists
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DeleteAliasOperation? DeleteOperation { get; init; }
#else
        public global::G.DeleteAliasOperation? DeleteOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteOperation))]
#endif
        public bool IsDeleteOperation => DeleteOperation != null;

        /// <summary>
        /// Change alias to a new one
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RenameAliasOperation? RenameOperation { get; init; }
#else
        public global::G.RenameAliasOperation? RenameOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RenameOperation))]
#endif
        public bool IsRenameOperation => RenameOperation != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AliasOperations(global::G.CreateAliasOperation value) => new AliasOperations((global::G.CreateAliasOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateAliasOperation?(AliasOperations @this) => @this.CreateOperation;

        /// <summary>
        /// 
        /// </summary>
        public AliasOperations(global::G.CreateAliasOperation? value)
        {
            CreateOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AliasOperations(global::G.DeleteAliasOperation value) => new AliasOperations((global::G.DeleteAliasOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DeleteAliasOperation?(AliasOperations @this) => @this.DeleteOperation;

        /// <summary>
        /// 
        /// </summary>
        public AliasOperations(global::G.DeleteAliasOperation? value)
        {
            DeleteOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AliasOperations(global::G.RenameAliasOperation value) => new AliasOperations((global::G.RenameAliasOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RenameAliasOperation?(AliasOperations @this) => @this.RenameOperation;

        /// <summary>
        /// 
        /// </summary>
        public AliasOperations(global::G.RenameAliasOperation? value)
        {
            RenameOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AliasOperations(
            global::G.CreateAliasOperation? createOperation,
            global::G.DeleteAliasOperation? deleteOperation,
            global::G.RenameAliasOperation? renameOperation
            )
        {
            CreateOperation = createOperation;
            DeleteOperation = deleteOperation;
            RenameOperation = renameOperation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RenameOperation as object ??
            DeleteOperation as object ??
            CreateOperation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateOperation?.ToString() ??
            DeleteOperation?.ToString() ??
            RenameOperation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateOperation || IsDeleteOperation || IsRenameOperation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateAliasOperation?, TResult>? createOperation = null,
            global::System.Func<global::G.DeleteAliasOperation?, TResult>? deleteOperation = null,
            global::System.Func<global::G.RenameAliasOperation?, TResult>? renameOperation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateOperation && createOperation != null)
            {
                return createOperation(CreateOperation!);
            }
            else if (IsDeleteOperation && deleteOperation != null)
            {
                return deleteOperation(DeleteOperation!);
            }
            else if (IsRenameOperation && renameOperation != null)
            {
                return renameOperation(RenameOperation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateAliasOperation?>? createOperation = null,
            global::System.Action<global::G.DeleteAliasOperation?>? deleteOperation = null,
            global::System.Action<global::G.RenameAliasOperation?>? renameOperation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateOperation)
            {
                createOperation?.Invoke(CreateOperation!);
            }
            else if (IsDeleteOperation)
            {
                deleteOperation?.Invoke(DeleteOperation!);
            }
            else if (IsRenameOperation)
            {
                renameOperation?.Invoke(RenameOperation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateOperation,
                typeof(global::G.CreateAliasOperation),
                DeleteOperation,
                typeof(global::G.DeleteAliasOperation),
                RenameOperation,
                typeof(global::G.RenameAliasOperation),
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
        public bool Equals(AliasOperations other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateAliasOperation?>.Default.Equals(CreateOperation, other.CreateOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DeleteAliasOperation?>.Default.Equals(DeleteOperation, other.DeleteOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RenameAliasOperation?>.Default.Equals(RenameOperation, other.RenameOperation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AliasOperations obj1, AliasOperations obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AliasOperations>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AliasOperations obj1, AliasOperations obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AliasOperations o && Equals(o);
        }
    }
}
