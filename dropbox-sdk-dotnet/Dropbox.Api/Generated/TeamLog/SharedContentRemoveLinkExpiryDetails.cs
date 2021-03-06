// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Removed link expiration date of shared file/folder.</para>
    /// </summary>
    public class SharedContentRemoveLinkExpiryDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentRemoveLinkExpiryDetails> Encoder = new SharedContentRemoveLinkExpiryDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentRemoveLinkExpiryDetails> Decoder = new SharedContentRemoveLinkExpiryDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentRemoveLinkExpiryDetails" /> class.</para>
        /// </summary>
        /// <param name="previousValue">Previous shared content link expiration date. Might be
        /// missing due to historical data gap.</param>
        public SharedContentRemoveLinkExpiryDetails(sys.DateTime? previousValue = null)
        {
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentRemoveLinkExpiryDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentRemoveLinkExpiryDetails()
        {
        }

        /// <summary>
        /// <para>Previous shared content link expiration date. Might be missing due to
        /// historical data gap.</para>
        /// </summary>
        public sys.DateTime? PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentRemoveLinkExpiryDetails" />.</para>
        /// </summary>
        private class SharedContentRemoveLinkExpiryDetailsEncoder : enc.StructEncoder<SharedContentRemoveLinkExpiryDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentRemoveLinkExpiryDetails value, enc.IJsonWriter writer)
            {
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue.Value, writer, enc.DateTimeEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentRemoveLinkExpiryDetails" />.</para>
        /// </summary>
        private class SharedContentRemoveLinkExpiryDetailsDecoder : enc.StructDecoder<SharedContentRemoveLinkExpiryDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharedContentRemoveLinkExpiryDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentRemoveLinkExpiryDetails Create()
            {
                return new SharedContentRemoveLinkExpiryDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentRemoveLinkExpiryDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "previous_value":
                        value.PreviousValue = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
