// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The delete error object</para>
    /// </summary>
    public class DeleteError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeleteError> Encoder = new DeleteErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeleteError> Decoder = new DeleteErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeleteError" /> class.</para>
        /// </summary>
        public DeleteError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PathLookup</para>
        /// </summary>
        public bool IsPathLookup
        {
            get
            {
                return this is PathLookup;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PathLookup, or <c>null</c>.</para>
        /// </summary>
        public PathLookup AsPathLookup
        {
            get
            {
                return this as PathLookup;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PathWrite</para>
        /// </summary>
        public bool IsPathWrite
        {
            get
            {
                return this is PathWrite;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PathWrite, or <c>null</c>.</para>
        /// </summary>
        public PathWrite AsPathWrite
        {
            get
            {
                return this as PathWrite;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// TooManyWriteOperations</para>
        /// </summary>
        public bool IsTooManyWriteOperations
        {
            get
            {
                return this is TooManyWriteOperations;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TooManyWriteOperations, or <c>null</c>.</para>
        /// </summary>
        public TooManyWriteOperations AsTooManyWriteOperations
        {
            get
            {
                return this as TooManyWriteOperations;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TooManyFiles</para>
        /// </summary>
        public bool IsTooManyFiles
        {
            get
            {
                return this is TooManyFiles;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TooManyFiles, or <c>null</c>.</para>
        /// </summary>
        public TooManyFiles AsTooManyFiles
        {
            get
            {
                return this as TooManyFiles;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeleteError" />.</para>
        /// </summary>
        private class DeleteErrorEncoder : enc.StructEncoder<DeleteError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeleteError value, enc.IJsonWriter writer)
            {
                if (value is PathLookup)
                {
                    WriteProperty(".tag", "path_lookup", writer, enc.StringEncoder.Instance);
                    PathLookup.Encoder.EncodeFields((PathLookup)value, writer);
                    return;
                }
                if (value is PathWrite)
                {
                    WriteProperty(".tag", "path_write", writer, enc.StringEncoder.Instance);
                    PathWrite.Encoder.EncodeFields((PathWrite)value, writer);
                    return;
                }
                if (value is TooManyWriteOperations)
                {
                    WriteProperty(".tag", "too_many_write_operations", writer, enc.StringEncoder.Instance);
                    TooManyWriteOperations.Encoder.EncodeFields((TooManyWriteOperations)value, writer);
                    return;
                }
                if (value is TooManyFiles)
                {
                    WriteProperty(".tag", "too_many_files", writer, enc.StringEncoder.Instance);
                    TooManyFiles.Encoder.EncodeFields((TooManyFiles)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeleteError" />.</para>
        /// </summary>
        private class DeleteErrorDecoder : enc.UnionDecoder<DeleteError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeleteError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeleteError Create()
            {
                return new DeleteError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override DeleteError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "path_lookup":
                        return PathLookup.Decoder.DecodeFields(reader);
                    case "path_write":
                        return PathWrite.Decoder.DecodeFields(reader);
                    case "too_many_write_operations":
                        return TooManyWriteOperations.Decoder.DecodeFields(reader);
                    case "too_many_files":
                        return TooManyFiles.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The path lookup object</para>
        /// </summary>
        public sealed class PathLookup : DeleteError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PathLookup> Encoder = new PathLookupEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PathLookup> Decoder = new PathLookupDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PathLookup" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public PathLookup(LookupError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PathLookup" /> class.</para>
            /// </summary>
            private PathLookup()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public LookupError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PathLookup" />.</para>
            /// </summary>
            private class PathLookupEncoder : enc.StructEncoder<PathLookup>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PathLookup value, enc.IJsonWriter writer)
                {
                    WriteProperty("path_lookup", value.Value, writer, global::Dropbox.Api.Files.LookupError.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PathLookup" />.</para>
            /// </summary>
            private class PathLookupDecoder : enc.StructDecoder<PathLookup>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PathLookup" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PathLookup Create()
                {
                    return new PathLookup();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(PathLookup value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "path_lookup":
                            value.Value = global::Dropbox.Api.Files.LookupError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The path write object</para>
        /// </summary>
        public sealed class PathWrite : DeleteError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PathWrite> Encoder = new PathWriteEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PathWrite> Decoder = new PathWriteDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PathWrite" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public PathWrite(WriteError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PathWrite" /> class.</para>
            /// </summary>
            private PathWrite()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public WriteError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PathWrite" />.</para>
            /// </summary>
            private class PathWriteEncoder : enc.StructEncoder<PathWrite>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PathWrite value, enc.IJsonWriter writer)
                {
                    WriteProperty("path_write", value.Value, writer, global::Dropbox.Api.Files.WriteError.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PathWrite" />.</para>
            /// </summary>
            private class PathWriteDecoder : enc.StructDecoder<PathWrite>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PathWrite" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PathWrite Create()
                {
                    return new PathWrite();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(PathWrite value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "path_write":
                            value.Value = global::Dropbox.Api.Files.WriteError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>There are too many write operations in user's Dropbox. Please retry this
        /// request.</para>
        /// </summary>
        public sealed class TooManyWriteOperations : DeleteError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TooManyWriteOperations> Encoder = new TooManyWriteOperationsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TooManyWriteOperations> Decoder = new TooManyWriteOperationsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TooManyWriteOperations" />
            /// class.</para>
            /// </summary>
            private TooManyWriteOperations()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TooManyWriteOperations</para>
            /// </summary>
            public static readonly TooManyWriteOperations Instance = new TooManyWriteOperations();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TooManyWriteOperations" />.</para>
            /// </summary>
            private class TooManyWriteOperationsEncoder : enc.StructEncoder<TooManyWriteOperations>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TooManyWriteOperations value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TooManyWriteOperations" />.</para>
            /// </summary>
            private class TooManyWriteOperationsDecoder : enc.StructDecoder<TooManyWriteOperations>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TooManyWriteOperations"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TooManyWriteOperations Create()
                {
                    return TooManyWriteOperations.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>There are too many files in one request. Please retry with fewer
        /// files.</para>
        /// </summary>
        public sealed class TooManyFiles : DeleteError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TooManyFiles> Encoder = new TooManyFilesEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TooManyFiles> Decoder = new TooManyFilesDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TooManyFiles" />
            /// class.</para>
            /// </summary>
            private TooManyFiles()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TooManyFiles</para>
            /// </summary>
            public static readonly TooManyFiles Instance = new TooManyFiles();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TooManyFiles" />.</para>
            /// </summary>
            private class TooManyFilesEncoder : enc.StructEncoder<TooManyFiles>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TooManyFiles value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TooManyFiles" />.</para>
            /// </summary>
            private class TooManyFilesDecoder : enc.StructDecoder<TooManyFiles>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TooManyFiles" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TooManyFiles Create()
                {
                    return TooManyFiles.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : DeleteError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
