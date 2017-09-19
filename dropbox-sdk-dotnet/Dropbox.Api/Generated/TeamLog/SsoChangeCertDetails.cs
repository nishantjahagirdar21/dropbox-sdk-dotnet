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
    /// <para>Changed the X.509 certificate for SSO.</para>
    /// </summary>
    public class SsoChangeCertDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SsoChangeCertDetails> Encoder = new SsoChangeCertDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SsoChangeCertDetails> Decoder = new SsoChangeCertDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SsoChangeCertDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="certificateDetails">SSO certificate details.</param>
        public SsoChangeCertDetails(Certificate certificateDetails)
        {
            if (certificateDetails == null)
            {
                throw new sys.ArgumentNullException("certificateDetails");
            }

            this.CertificateDetails = certificateDetails;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SsoChangeCertDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SsoChangeCertDetails()
        {
        }

        /// <summary>
        /// <para>SSO certificate details.</para>
        /// </summary>
        public Certificate CertificateDetails { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SsoChangeCertDetails" />.</para>
        /// </summary>
        private class SsoChangeCertDetailsEncoder : enc.StructEncoder<SsoChangeCertDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SsoChangeCertDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("certificate_details", value.CertificateDetails, writer, global::Dropbox.Api.TeamLog.Certificate.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SsoChangeCertDetails" />.</para>
        /// </summary>
        private class SsoChangeCertDetailsDecoder : enc.StructDecoder<SsoChangeCertDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SsoChangeCertDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SsoChangeCertDetails Create()
            {
                return new SsoChangeCertDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SsoChangeCertDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "certificate_details":
                        value.CertificateDetails = global::Dropbox.Api.TeamLog.Certificate.Decoder.Decode(reader);
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