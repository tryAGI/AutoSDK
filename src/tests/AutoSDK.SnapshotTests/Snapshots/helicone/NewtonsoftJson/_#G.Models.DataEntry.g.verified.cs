//HintName: G.Models.DataEntry.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataEntry : global::System.IEquatable<DataEntry>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DataEntryVariant1? DataEntryVariant1 { get; init; }
#else
        public global::G.DataEntryVariant1? DataEntryVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DataEntryVariant1))]
#endif
        public bool IsDataEntryVariant1 => DataEntryVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DataEntryVariant2? DataEntryVariant2 { get; init; }
#else
        public global::G.DataEntryVariant2? DataEntryVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DataEntryVariant2))]
#endif
        public bool IsDataEntryVariant2 => DataEntryVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DataEntryVariant3? DataEntryVariant3 { get; init; }
#else
        public global::G.DataEntryVariant3? DataEntryVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DataEntryVariant3))]
#endif
        public bool IsDataEntryVariant3 => DataEntryVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DataEntryVariant4? DataEntryVariant4 { get; init; }
#else
        public global::G.DataEntryVariant4? DataEntryVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DataEntryVariant4))]
#endif
        public bool IsDataEntryVariant4 => DataEntryVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataEntry(global::G.DataEntryVariant1 value) => new DataEntry((global::G.DataEntryVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DataEntryVariant1?(DataEntry @this) => @this.DataEntryVariant1;

        /// <summary>
        /// 
        /// </summary>
        public DataEntry(global::G.DataEntryVariant1? value)
        {
            DataEntryVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataEntry(global::G.DataEntryVariant2 value) => new DataEntry((global::G.DataEntryVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DataEntryVariant2?(DataEntry @this) => @this.DataEntryVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DataEntry(global::G.DataEntryVariant2? value)
        {
            DataEntryVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataEntry(global::G.DataEntryVariant3 value) => new DataEntry((global::G.DataEntryVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DataEntryVariant3?(DataEntry @this) => @this.DataEntryVariant3;

        /// <summary>
        /// 
        /// </summary>
        public DataEntry(global::G.DataEntryVariant3? value)
        {
            DataEntryVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataEntry(global::G.DataEntryVariant4 value) => new DataEntry((global::G.DataEntryVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DataEntryVariant4?(DataEntry @this) => @this.DataEntryVariant4;

        /// <summary>
        /// 
        /// </summary>
        public DataEntry(global::G.DataEntryVariant4? value)
        {
            DataEntryVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataEntry(
            global::G.DataEntryVariant1? dataEntryVariant1,
            global::G.DataEntryVariant2? dataEntryVariant2,
            global::G.DataEntryVariant3? dataEntryVariant3,
            global::G.DataEntryVariant4? dataEntryVariant4
            )
        {
            DataEntryVariant1 = dataEntryVariant1;
            DataEntryVariant2 = dataEntryVariant2;
            DataEntryVariant3 = dataEntryVariant3;
            DataEntryVariant4 = dataEntryVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DataEntryVariant4 as object ??
            DataEntryVariant3 as object ??
            DataEntryVariant2 as object ??
            DataEntryVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DataEntryVariant1?.ToString() ??
            DataEntryVariant2?.ToString() ??
            DataEntryVariant3?.ToString() ??
            DataEntryVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDataEntryVariant1 || IsDataEntryVariant2 || IsDataEntryVariant3 || IsDataEntryVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.DataEntryVariant1?, TResult>? dataEntryVariant1 = null,
            global::System.Func<global::G.DataEntryVariant2?, TResult>? dataEntryVariant2 = null,
            global::System.Func<global::G.DataEntryVariant3?, TResult>? dataEntryVariant3 = null,
            global::System.Func<global::G.DataEntryVariant4?, TResult>? dataEntryVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDataEntryVariant1 && dataEntryVariant1 != null)
            {
                return dataEntryVariant1(DataEntryVariant1!);
            }
            else if (IsDataEntryVariant2 && dataEntryVariant2 != null)
            {
                return dataEntryVariant2(DataEntryVariant2!);
            }
            else if (IsDataEntryVariant3 && dataEntryVariant3 != null)
            {
                return dataEntryVariant3(DataEntryVariant3!);
            }
            else if (IsDataEntryVariant4 && dataEntryVariant4 != null)
            {
                return dataEntryVariant4(DataEntryVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.DataEntryVariant1?>? dataEntryVariant1 = null,
            global::System.Action<global::G.DataEntryVariant2?>? dataEntryVariant2 = null,
            global::System.Action<global::G.DataEntryVariant3?>? dataEntryVariant3 = null,
            global::System.Action<global::G.DataEntryVariant4?>? dataEntryVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDataEntryVariant1)
            {
                dataEntryVariant1?.Invoke(DataEntryVariant1!);
            }
            else if (IsDataEntryVariant2)
            {
                dataEntryVariant2?.Invoke(DataEntryVariant2!);
            }
            else if (IsDataEntryVariant3)
            {
                dataEntryVariant3?.Invoke(DataEntryVariant3!);
            }
            else if (IsDataEntryVariant4)
            {
                dataEntryVariant4?.Invoke(DataEntryVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DataEntryVariant1,
                typeof(global::G.DataEntryVariant1),
                DataEntryVariant2,
                typeof(global::G.DataEntryVariant2),
                DataEntryVariant3,
                typeof(global::G.DataEntryVariant3),
                DataEntryVariant4,
                typeof(global::G.DataEntryVariant4),
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
        public bool Equals(DataEntry other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.DataEntryVariant1?>.Default.Equals(DataEntryVariant1, other.DataEntryVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DataEntryVariant2?>.Default.Equals(DataEntryVariant2, other.DataEntryVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DataEntryVariant3?>.Default.Equals(DataEntryVariant3, other.DataEntryVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DataEntryVariant4?>.Default.Equals(DataEntryVariant4, other.DataEntryVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataEntry obj1, DataEntry obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataEntry>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataEntry obj1, DataEntry obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataEntry o && Equals(o);
        }
    }
}
