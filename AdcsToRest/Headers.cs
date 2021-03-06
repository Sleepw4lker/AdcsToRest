// Some constants that are defined in Windows SDK header files

namespace AdcsToRest
{
    // Constants from CertCli.h
    internal static class CertCli
    {
        public const int CR_IN_PKCS10 = 0x100;
        public const int CR_IN_KEYGEN = 0x200;
        public const int CR_IN_PKCS7 = 0x300;
        public const int CR_IN_CMC = 0x400;
        public const int CR_IN_FULLRESPONSE = 0x40000;

        public const int CR_IN_BASE64HEADER = 0;
        public const int CR_IN_BASE64 = 1;
        public const int CR_OUT_BASE64HEADER = 0;
        public const int CR_OUT_BASE64 = 1;
        public const int CR_OUT_CHAIN = 0x100;

        public const int CR_DISP_INCOMPLETE = 0;
        public const int CR_DISP_ERROR = 1;
        public const int CR_DISP_DENIED = 2;
        public const int CR_DISP_ISSUED = 3;
        public const int CR_DISP_ISSUED_OUT_OF_BAND = 4;
        public const int CR_DISP_UNDER_SUBMISSION = 5;

        public const int CR_PROP_CASIGCERTCOUNT = 11;
        public const int CR_PROP_CASIGCERT = 12;
        public const int CR_PROP_BASECRL = 17;
        public const int CR_PROP_DELTACRL = 18;
        public const int CR_PROP_CRLSTATE = 20;
        public const int CR_PROP_CERTCDPURLS = 41;
        public const int CR_PROP_CERTAIAURLS = 42;
        public const int CR_PROP_CERTAIAOCSPURLS = 43;
    }

    // Constants from CertSrv.h
    internal static class CertSrv
    {
        public const int PROPTYPE_LONG = 1;
        public const int PROPTYPE_BINARY = 3;
        public const int PROPTYPE_STRING = 4;
    }

    // Constants from CertView.h
    internal static class CertView
    {
        public const int CV_OUT_BASE64HEADER = 0;
        public const int CV_OUT_BASE64X509CRLHEADER = 0x9;
    }

    // Constants from CertAdm.h
    internal static class CertAdm
    {
        public const int CA_DISP_INCOMPLETE = 0;
        public const int CA_DISP_ERROR = 0x1;
        public const int CA_DISP_REVOKED = 0x2;
        public const int CA_DISP_VALID = 0x3;
        public const int CA_DISP_INVALID = 0x4;
        public const int CA_DISP_UNDER_SUBMISSION = 0x5;
    }

    // Constants from WinError.h
    internal static class WinError
    {
        // The operation completed successfully.
        public const int ERROR_SUCCESS = 0;
    }
}