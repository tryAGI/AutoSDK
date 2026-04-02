//HintName: G.Models.BatchVectorStruct.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BatchVectorStruct : global::System.IEquatable<BatchVectorStruct>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? BatchVectorStructVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? BatchVectorStructVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BatchVectorStructVariant1))]
#endif
        public bool IsBatchVectorStructVariant1 => BatchVectorStructVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? BatchVectorStructVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? BatchVectorStructVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BatchVectorStructVariant2))]
#endif
        public bool IsBatchVectorStructVariant2 => BatchVectorStructVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.Vector>>? BatchVectorStructVariant3 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.Vector>>? BatchVectorStructVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BatchVectorStructVariant3))]
#endif
        public bool IsBatchVectorStructVariant3 => BatchVectorStructVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.Document>? BatchVectorStructVariant4 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.Document>? BatchVectorStructVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BatchVectorStructVariant4))]
#endif
        public bool IsBatchVectorStructVariant4 => BatchVectorStructVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.Image>? BatchVectorStructVariant5 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.Image>? BatchVectorStructVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BatchVectorStructVariant5))]
#endif
        public bool IsBatchVectorStructVariant5 => BatchVectorStructVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.InferenceObject>? BatchVectorStructVariant6 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.InferenceObject>? BatchVectorStructVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BatchVectorStructVariant6))]
#endif
        public bool IsBatchVectorStructVariant6 => BatchVectorStructVariant6 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BatchVectorStruct(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.Vector>> value) => new BatchVectorStruct((global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.Vector>>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.Vector>>?(BatchVectorStruct @this) => @this.BatchVectorStructVariant3;

        /// <summary>
        /// 
        /// </summary>
        public BatchVectorStruct(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.Vector>>? value)
        {
            BatchVectorStructVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BatchVectorStruct(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? batchVectorStructVariant1,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? batchVectorStructVariant2,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.Vector>>? batchVectorStructVariant3,
            global::System.Collections.Generic.IList<global::G.Document>? batchVectorStructVariant4,
            global::System.Collections.Generic.IList<global::G.Image>? batchVectorStructVariant5,
            global::System.Collections.Generic.IList<global::G.InferenceObject>? batchVectorStructVariant6
            )
        {
            BatchVectorStructVariant1 = batchVectorStructVariant1;
            BatchVectorStructVariant2 = batchVectorStructVariant2;
            BatchVectorStructVariant3 = batchVectorStructVariant3;
            BatchVectorStructVariant4 = batchVectorStructVariant4;
            BatchVectorStructVariant5 = batchVectorStructVariant5;
            BatchVectorStructVariant6 = batchVectorStructVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BatchVectorStructVariant6 as object ??
            BatchVectorStructVariant5 as object ??
            BatchVectorStructVariant4 as object ??
            BatchVectorStructVariant3 as object ??
            BatchVectorStructVariant2 as object ??
            BatchVectorStructVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BatchVectorStructVariant1?.ToString() ??
            BatchVectorStructVariant2?.ToString() ??
            BatchVectorStructVariant3?.ToString() ??
            BatchVectorStructVariant4?.ToString() ??
            BatchVectorStructVariant5?.ToString() ??
            BatchVectorStructVariant6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBatchVectorStructVariant1 || IsBatchVectorStructVariant2 || IsBatchVectorStructVariant3 || IsBatchVectorStructVariant4 || IsBatchVectorStructVariant5 || IsBatchVectorStructVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?, TResult>? batchVectorStructVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>?, TResult>? batchVectorStructVariant2 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.Vector>>?, TResult>? batchVectorStructVariant3 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.Document>?, TResult>? batchVectorStructVariant4 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.Image>?, TResult>? batchVectorStructVariant5 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.InferenceObject>?, TResult>? batchVectorStructVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBatchVectorStructVariant1 && batchVectorStructVariant1 != null)
            {
                return batchVectorStructVariant1(BatchVectorStructVariant1!);
            }
            else if (IsBatchVectorStructVariant2 && batchVectorStructVariant2 != null)
            {
                return batchVectorStructVariant2(BatchVectorStructVariant2!);
            }
            else if (IsBatchVectorStructVariant3 && batchVectorStructVariant3 != null)
            {
                return batchVectorStructVariant3(BatchVectorStructVariant3!);
            }
            else if (IsBatchVectorStructVariant4 && batchVectorStructVariant4 != null)
            {
                return batchVectorStructVariant4(BatchVectorStructVariant4!);
            }
            else if (IsBatchVectorStructVariant5 && batchVectorStructVariant5 != null)
            {
                return batchVectorStructVariant5(BatchVectorStructVariant5!);
            }
            else if (IsBatchVectorStructVariant6 && batchVectorStructVariant6 != null)
            {
                return batchVectorStructVariant6(BatchVectorStructVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>? batchVectorStructVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>?>? batchVectorStructVariant2 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.Vector>>?>? batchVectorStructVariant3 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.Document>?>? batchVectorStructVariant4 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.Image>?>? batchVectorStructVariant5 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.InferenceObject>?>? batchVectorStructVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBatchVectorStructVariant1)
            {
                batchVectorStructVariant1?.Invoke(BatchVectorStructVariant1!);
            }
            else if (IsBatchVectorStructVariant2)
            {
                batchVectorStructVariant2?.Invoke(BatchVectorStructVariant2!);
            }
            else if (IsBatchVectorStructVariant3)
            {
                batchVectorStructVariant3?.Invoke(BatchVectorStructVariant3!);
            }
            else if (IsBatchVectorStructVariant4)
            {
                batchVectorStructVariant4?.Invoke(BatchVectorStructVariant4!);
            }
            else if (IsBatchVectorStructVariant5)
            {
                batchVectorStructVariant5?.Invoke(BatchVectorStructVariant5!);
            }
            else if (IsBatchVectorStructVariant6)
            {
                batchVectorStructVariant6?.Invoke(BatchVectorStructVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BatchVectorStructVariant1,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>),
                BatchVectorStructVariant2,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>),
                BatchVectorStructVariant3,
                typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.Vector>>),
                BatchVectorStructVariant4,
                typeof(global::System.Collections.Generic.IList<global::G.Document>),
                BatchVectorStructVariant5,
                typeof(global::System.Collections.Generic.IList<global::G.Image>),
                BatchVectorStructVariant6,
                typeof(global::System.Collections.Generic.IList<global::G.InferenceObject>),
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
        public bool Equals(BatchVectorStruct other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>.Default.Equals(BatchVectorStructVariant1, other.BatchVectorStructVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>?>.Default.Equals(BatchVectorStructVariant2, other.BatchVectorStructVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.Vector>>?>.Default.Equals(BatchVectorStructVariant3, other.BatchVectorStructVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.Document>?>.Default.Equals(BatchVectorStructVariant4, other.BatchVectorStructVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.Image>?>.Default.Equals(BatchVectorStructVariant5, other.BatchVectorStructVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.InferenceObject>?>.Default.Equals(BatchVectorStructVariant6, other.BatchVectorStructVariant6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BatchVectorStruct obj1, BatchVectorStruct obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BatchVectorStruct>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BatchVectorStruct obj1, BatchVectorStruct obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BatchVectorStruct o && Equals(o);
        }
    }
}
