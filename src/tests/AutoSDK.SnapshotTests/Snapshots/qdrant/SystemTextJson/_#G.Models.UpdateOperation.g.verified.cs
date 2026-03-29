//HintName: G.Models.UpdateOperation.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateOperation : global::System.IEquatable<UpdateOperation>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpsertOperation? Upsert { get; init; }
#else
        public global::G.UpsertOperation? Upsert { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Upsert))]
#endif
        public bool IsUpsert => Upsert != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DeleteOperation? Delete { get; init; }
#else
        public global::G.DeleteOperation? Delete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Delete))]
#endif
        public bool IsDelete => Delete != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SetPayloadOperation? SetPayload { get; init; }
#else
        public global::G.SetPayloadOperation? SetPayload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SetPayload))]
#endif
        public bool IsSetPayload => SetPayload != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OverwritePayloadOperation? OverwritePayload { get; init; }
#else
        public global::G.OverwritePayloadOperation? OverwritePayload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OverwritePayload))]
#endif
        public bool IsOverwritePayload => OverwritePayload != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DeletePayloadOperation? DeletePayload { get; init; }
#else
        public global::G.DeletePayloadOperation? DeletePayload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeletePayload))]
#endif
        public bool IsDeletePayload => DeletePayload != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClearPayloadOperation? ClearPayload { get; init; }
#else
        public global::G.ClearPayloadOperation? ClearPayload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClearPayload))]
#endif
        public bool IsClearPayload => ClearPayload != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateVectorsOperation? Vectors { get; init; }
#else
        public global::G.UpdateVectorsOperation? Vectors { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vectors))]
#endif
        public bool IsVectors => Vectors != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DeleteVectorsOperation? DeleteVectors { get; init; }
#else
        public global::G.DeleteVectorsOperation? DeleteVectors { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteVectors))]
#endif
        public bool IsDeleteVectors => DeleteVectors != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::G.UpsertOperation value) => new UpdateOperation((global::G.UpsertOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpsertOperation?(UpdateOperation @this) => @this.Upsert;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::G.UpsertOperation? value)
        {
            Upsert = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::G.DeleteOperation value) => new UpdateOperation((global::G.DeleteOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DeleteOperation?(UpdateOperation @this) => @this.Delete;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::G.DeleteOperation? value)
        {
            Delete = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::G.SetPayloadOperation value) => new UpdateOperation((global::G.SetPayloadOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SetPayloadOperation?(UpdateOperation @this) => @this.SetPayload;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::G.SetPayloadOperation? value)
        {
            SetPayload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::G.OverwritePayloadOperation value) => new UpdateOperation((global::G.OverwritePayloadOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OverwritePayloadOperation?(UpdateOperation @this) => @this.OverwritePayload;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::G.OverwritePayloadOperation? value)
        {
            OverwritePayload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::G.DeletePayloadOperation value) => new UpdateOperation((global::G.DeletePayloadOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DeletePayloadOperation?(UpdateOperation @this) => @this.DeletePayload;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::G.DeletePayloadOperation? value)
        {
            DeletePayload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::G.ClearPayloadOperation value) => new UpdateOperation((global::G.ClearPayloadOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClearPayloadOperation?(UpdateOperation @this) => @this.ClearPayload;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::G.ClearPayloadOperation? value)
        {
            ClearPayload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::G.UpdateVectorsOperation value) => new UpdateOperation((global::G.UpdateVectorsOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateVectorsOperation?(UpdateOperation @this) => @this.Vectors;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::G.UpdateVectorsOperation? value)
        {
            Vectors = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::G.DeleteVectorsOperation value) => new UpdateOperation((global::G.DeleteVectorsOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DeleteVectorsOperation?(UpdateOperation @this) => @this.DeleteVectors;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::G.DeleteVectorsOperation? value)
        {
            DeleteVectors = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(
            global::G.UpsertOperation? upsert,
            global::G.DeleteOperation? delete,
            global::G.SetPayloadOperation? setPayload,
            global::G.OverwritePayloadOperation? overwritePayload,
            global::G.DeletePayloadOperation? deletePayload,
            global::G.ClearPayloadOperation? clearPayload,
            global::G.UpdateVectorsOperation? vectors,
            global::G.DeleteVectorsOperation? deleteVectors
            )
        {
            Upsert = upsert;
            Delete = delete;
            SetPayload = setPayload;
            OverwritePayload = overwritePayload;
            DeletePayload = deletePayload;
            ClearPayload = clearPayload;
            Vectors = vectors;
            DeleteVectors = deleteVectors;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DeleteVectors as object ??
            Vectors as object ??
            ClearPayload as object ??
            DeletePayload as object ??
            OverwritePayload as object ??
            SetPayload as object ??
            Delete as object ??
            Upsert as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Upsert?.ToString() ??
            Delete?.ToString() ??
            SetPayload?.ToString() ??
            OverwritePayload?.ToString() ??
            DeletePayload?.ToString() ??
            ClearPayload?.ToString() ??
            Vectors?.ToString() ??
            DeleteVectors?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUpsert || IsDelete || IsSetPayload || IsOverwritePayload || IsDeletePayload || IsClearPayload || IsVectors || IsDeleteVectors;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.UpsertOperation?, TResult>? upsert = null,
            global::System.Func<global::G.DeleteOperation?, TResult>? delete = null,
            global::System.Func<global::G.SetPayloadOperation?, TResult>? setPayload = null,
            global::System.Func<global::G.OverwritePayloadOperation?, TResult>? overwritePayload = null,
            global::System.Func<global::G.DeletePayloadOperation?, TResult>? deletePayload = null,
            global::System.Func<global::G.ClearPayloadOperation?, TResult>? clearPayload = null,
            global::System.Func<global::G.UpdateVectorsOperation?, TResult>? vectors = null,
            global::System.Func<global::G.DeleteVectorsOperation?, TResult>? deleteVectors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpsert && upsert != null)
            {
                return upsert(Upsert!);
            }
            else if (IsDelete && delete != null)
            {
                return delete(Delete!);
            }
            else if (IsSetPayload && setPayload != null)
            {
                return setPayload(SetPayload!);
            }
            else if (IsOverwritePayload && overwritePayload != null)
            {
                return overwritePayload(OverwritePayload!);
            }
            else if (IsDeletePayload && deletePayload != null)
            {
                return deletePayload(DeletePayload!);
            }
            else if (IsClearPayload && clearPayload != null)
            {
                return clearPayload(ClearPayload!);
            }
            else if (IsVectors && vectors != null)
            {
                return vectors(Vectors!);
            }
            else if (IsDeleteVectors && deleteVectors != null)
            {
                return deleteVectors(DeleteVectors!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.UpsertOperation?>? upsert = null,
            global::System.Action<global::G.DeleteOperation?>? delete = null,
            global::System.Action<global::G.SetPayloadOperation?>? setPayload = null,
            global::System.Action<global::G.OverwritePayloadOperation?>? overwritePayload = null,
            global::System.Action<global::G.DeletePayloadOperation?>? deletePayload = null,
            global::System.Action<global::G.ClearPayloadOperation?>? clearPayload = null,
            global::System.Action<global::G.UpdateVectorsOperation?>? vectors = null,
            global::System.Action<global::G.DeleteVectorsOperation?>? deleteVectors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpsert)
            {
                upsert?.Invoke(Upsert!);
            }
            else if (IsDelete)
            {
                delete?.Invoke(Delete!);
            }
            else if (IsSetPayload)
            {
                setPayload?.Invoke(SetPayload!);
            }
            else if (IsOverwritePayload)
            {
                overwritePayload?.Invoke(OverwritePayload!);
            }
            else if (IsDeletePayload)
            {
                deletePayload?.Invoke(DeletePayload!);
            }
            else if (IsClearPayload)
            {
                clearPayload?.Invoke(ClearPayload!);
            }
            else if (IsVectors)
            {
                vectors?.Invoke(Vectors!);
            }
            else if (IsDeleteVectors)
            {
                deleteVectors?.Invoke(DeleteVectors!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Upsert,
                typeof(global::G.UpsertOperation),
                Delete,
                typeof(global::G.DeleteOperation),
                SetPayload,
                typeof(global::G.SetPayloadOperation),
                OverwritePayload,
                typeof(global::G.OverwritePayloadOperation),
                DeletePayload,
                typeof(global::G.DeletePayloadOperation),
                ClearPayload,
                typeof(global::G.ClearPayloadOperation),
                Vectors,
                typeof(global::G.UpdateVectorsOperation),
                DeleteVectors,
                typeof(global::G.DeleteVectorsOperation),
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
        public bool Equals(UpdateOperation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UpsertOperation?>.Default.Equals(Upsert, other.Upsert) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DeleteOperation?>.Default.Equals(Delete, other.Delete) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SetPayloadOperation?>.Default.Equals(SetPayload, other.SetPayload) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OverwritePayloadOperation?>.Default.Equals(OverwritePayload, other.OverwritePayload) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DeletePayloadOperation?>.Default.Equals(DeletePayload, other.DeletePayload) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ClearPayloadOperation?>.Default.Equals(ClearPayload, other.ClearPayload) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateVectorsOperation?>.Default.Equals(Vectors, other.Vectors) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DeleteVectorsOperation?>.Default.Equals(DeleteVectors, other.DeleteVectors) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateOperation obj1, UpdateOperation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateOperation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateOperation obj1, UpdateOperation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateOperation o && Equals(o);
        }
    }
}
