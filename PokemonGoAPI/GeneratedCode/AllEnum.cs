#pragma warning disable 1591, 0612, 3021

#region Designer generated code

#region

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;

#endregion

namespace AllEnum
{
    /// <summary>Holder for reflection information generated from AllEnum.proto</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class AllEnumReflection
    {
        #region Descriptor

        /// <summary>File descriptor for AllEnum.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static pbr::FileDescriptor descriptor;

        static AllEnumReflection()
        {
            var descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                    "Cg1BbGxFbnVtLnByb3RvEgdBbGxFbnVtKjYKDFJwY0RpcmVjdGlvbhILCgdV",
                    "TktOT1dOEAASDAoIUkVTUE9OU0UQARILCgdSRVFVRVNUEAIqNwoJVGVhbUNv",
                    "bG9yEgsKB05FVVRSQUwQABIICgRCTFVFEAESBwoDUkVEEAISCgoGWUVMTE9X",
                    "EAMqwwwKDVJlcXVlc3RNZXRob2QSEAoMTUVUSE9EX1VOU0VUEAASEQoNUExB",
                    "WUVSX1VQREFURRABEg4KCkdFVF9QTEFZRVIQAhIRCg1HRVRfSU5WRU5UT1JZ",
                    "EAQSFQoRRE9XTkxPQURfU0VUVElOR1MQBRIbChdET1dOTE9BRF9JVEVNX1RF",
                    "TVBMQVRFUxAGEiIKHkRPV05MT0FEX1JFTU9URV9DT05GSUdfVkVSU0lPThAH",
                    "Eg8KC0ZPUlRfU0VBUkNIEGUSDQoJRU5DT1VOVEVSEGYSEQoNQ0FUQ0hfUE9L",
                    "RU1PThBnEhAKDEZPUlRfREVUQUlMUxBoEgwKCElURU1fVVNFEGkSEwoPR0VU",
                    "X01BUF9PQkpFQ1RTEGoSFwoTRk9SVF9ERVBMT1lfUE9LRU1PThBuEhcKE0ZP",
                    "UlRfUkVDQUxMX1BPS0VNT04QbxITCg9SRUxFQVNFX1BPS0VNT04QcBITCg9V",
                    "U0VfSVRFTV9QT1RJT04QcRIUChBVU0VfSVRFTV9DQVBUVVJFEHISEQoNVVNF",
                    "X0lURU1fRkxFRRBzEhMKD1VTRV9JVEVNX1JFVklWRRB0EhAKDFRSQURFX1NF",
                    "QVJDSBB1Eg8KC1RSQURFX09GRkVSEHYSEgoOVFJBREVfUkVTUE9OU0UQdxIQ",
                    "CgxUUkFERV9SRVNVTFQQeBIWChJHRVRfUExBWUVSX1BST0ZJTEUQeRIRCg1H",
                    "RVRfSVRFTV9QQUNLEHoSEQoNQlVZX0lURU1fUEFDSxB7EhAKDEJVWV9HRU1f",
                    "UEFDSxB8EhIKDkVWT0xWRV9QT0tFTU9OEH0SFAoQR0VUX0hBVENIRURfRUdH",
                    "UxB+Eh8KG0VOQ09VTlRFUl9UVVRPUklBTF9DT01QTEVURRB/EhUKEExFVkVM",
                    "X1VQX1JFV0FSRFMQgAESGQoUQ0hFQ0tfQVdBUkRFRF9CQURHRVMQgQESEQoM",
                    "VVNFX0lURU1fR1lNEIUBEhQKD0dFVF9HWU1fREVUQUlMUxCGARIVChBTVEFS",
                    "VF9HWU1fQkFUVExFEIcBEg8KCkFUVEFDS19HWU0QiAESGwoWUkVDWUNMRV9J",
                    "TlZFTlRPUllfSVRFTRCJARIYChNDT0xMRUNUX0RBSUxZX0JPTlVTEIoBEhYK",
                    "EVVTRV9JVEVNX1hQX0JPT1NUEIsBEhsKFlVTRV9JVEVNX0VHR19JTkNVQkFU",
                    "T1IQjAESEAoLVVNFX0lOQ0VOU0UQjQESGAoTR0VUX0lOQ0VOU0VfUE9LRU1P",
                    "ThCOARIWChFJTkNFTlNFX0VOQ09VTlRFUhCPARIWChFBRERfRk9SVF9NT0RJ",
                    "RklFUhCQARITCg5ESVNLX0VOQ09VTlRFUhCRARIhChxDT0xMRUNUX0RBSUxZ",
                    "X0RFRkVOREVSX0JPTlVTEJIBEhQKD1VQR1JBREVfUE9LRU1PThCTARIZChRT",
                    "RVRfRkFWT1JJVEVfUE9LRU1PThCUARIVChBOSUNLTkFNRV9QT0tFTU9OEJUB",
                    "EhAKC0VRVUlQX0JBREdFEJYBEhkKFFNFVF9DT05UQUNUX1NFVFRJTkdTEJcB",
                    "EhUKEEdFVF9BU1NFVF9ESUdFU1QQrAISFgoRR0VUX0RPV05MT0FEX1VSTFMQ",
                    "rQISHAoXR0VUX1NVR0dFU1RFRF9DT0RFTkFNRVMQkQMSHQoYQ0hFQ0tfQ09E",
                    "RU5BTUVfQVZBSUxBQkxFEJIDEhMKDkNMQUlNX0NPREVOQU1FEJMDEg8KClNF",
                    "VF9BVkFUQVIQlAMSFAoPU0VUX1BMQVlFUl9URUFNEJUDEhsKFk1BUktfVFVU",
                    "T1JJQUxfQ09NUExFVEUQlgMSFgoRTE9BRF9TUEFXTl9QT0lOVFMQ9AMSCQoE",
                    "RUNITxCaBRIbChZERUJVR19VUERBVEVfSU5WRU5UT1JZELwFEhgKE0RFQlVH",
                    "X0RFTEVURV9QTEFZRVIQvQUSFwoSU0ZJREFfUkVHSVNUUkFUSU9OEKAGEhUK",
                    "EFNGSURBX0FDVElPTl9MT0cQoQYSGAoTU0ZJREFfQ0VSVElGSUNBVElPThCi",
                    "BhIRCgxTRklEQV9VUERBVEUQowYSEQoMU0ZJREFfQUNUSU9OEKQGEhEKDFNG",
                    "SURBX0RPV1NFUhClBhISCg1TRklEQV9DQVBUVVJFEKYGKs4XCgtQb2tlbW9u",
                    "TW92ZRIOCgpNT1ZFX1VOU0VUEAASEQoNVEhVTkRFUl9TSE9DSxABEhAKDFFV",
                    "SUNLX0FUVEFDSxACEgsKB1NDUkFUQ0gQAxIJCgVFTUJFUhAEEg0KCVZJTkVf",
                    "V0hJUBAFEgoKBlRBQ0tMRRAGEg4KClJBWk9SX0xFQUYQBxINCglUQUtFX0RP",
                    "V04QCBINCglXQVRFUl9HVU4QCRIICgRCSVRFEAoSCQoFUE9VTkQQCxIPCgtE",
                    "T1VCTEVfU0xBUBAMEggKBFdSQVAQDRIOCgpIWVBFUl9CRUFNEA4SCAoETElD",
                    "SxAPEg4KCkRBUktfUFVMU0UQEBIICgRTTU9HEBESCgoGU0xVREdFEBISDgoK",
                    "TUVUQUxfQ0xBVxATEg0KCVZJQ0VfR1JJUBAUEg8KC0ZMQU1FX1dIRUVMEBUS",
                    "DAoITUVHQUhPUk4QFhIPCgtXSU5HX0FUVEFDSxAXEhAKDEZMQU1FVEhST1dF",
                    "UhAYEhAKDFNVQ0tFUl9QVU5DSBAZEgcKA0RJRxAaEgwKCExPV19LSUNLEBsS",
                    "DgoKQ1JPU1NfQ0hPUBAcEg4KClBTWUNIT19DVVQQHRILCgdQU1lCRUFNEB4S",
                    "DgoKRUFSVEhRVUFLRRAfEg4KClNUT05FX0VER0UQIBINCglJQ0VfUFVOQ0gQ",
                    "IRIPCgtIRUFSVF9TVEFNUBAiEg0KCURJU0NIQVJHRRAjEhAKDEZMQVNIX0NB",
                    "Tk5PThAkEggKBFBFQ0sQJRIOCgpEUklMTF9QRUNLECYSDAoISUNFX0JFQU0Q",
                    "JxIMCghCTElaWkFSRBAoEg0KCUFJUl9TTEFTSBApEg0KCUhFQVRfV0FWRRAq",
                    "Eg0KCVRXSU5FRURMRRArEg4KClBPSVNPTl9KQUIQLBIOCgpBRVJJQUxfQUNF",
                    "EC0SDQoJRFJJTExfUlVOEC4SEgoOUEVUQUxfQkxJWlpBUkQQLxIOCgpNRUdB",
                    "X0RSQUlOEDASDAoIQlVHX0JVWloQMRIPCgtQT0lTT05fRkFORxAyEg8KC05J",
                    "R0hUX1NMQVNIEDMSCQoFU0xBU0gQNBIPCgtCVUJCTEVfQkVBTRA1Eg4KClNV",
                    "Qk1JU1NJT04QNhIPCgtLQVJBVEVfQ0hPUBA3Eg0KCUxPV19TV0VFUBA4EgwK",
                    "CEFRVUFfSkVUEDkSDQoJQVFVQV9UQUlMEDoSDQoJU0VFRF9CT01CEDsSDAoI",
                    "UFNZU0hPQ0sQPBIOCgpST0NLX1RIUk9XED0SEQoNQU5DSUVOVF9QT1dFUhA+",
                    "Eg0KCVJPQ0tfVE9NQhA/Eg4KClJPQ0tfU0xJREUQQBINCglQT1dFUl9HRU0Q",
                    "QRIQCgxTSEFET1dfU05FQUsQQhIQCgxTSEFET1dfUFVOQ0gQQxIPCgtTSEFE",
                    "T1dfQ0xBVxBEEhAKDE9NSU5PVVNfV0lORBBFEg8KC1NIQURPV19CQUxMEEYS",
                    "EAoMQlVMTEVUX1BVTkNIEEcSDwoLTUFHTkVUX0JPTUIQSBIOCgpTVEVFTF9X",
                    "SU5HEEkSDQoJSVJPTl9IRUFEEEoSFAoQUEFSQUJPTElDX0NIQVJHRRBLEgkK",
                    "BVNQQVJLEEwSEQoNVEhVTkRFUl9QVU5DSBBNEgsKB1RIVU5ERVIQThIPCgtU",
                    "SFVOREVSQk9MVBBPEgsKB1RXSVNURVIQUBIRCg1EUkFHT05fQlJFQVRIEFES",
                    "EAoMRFJBR09OX1BVTFNFEFISDwoLRFJBR09OX0NMQVcQUxITCg9ESVNBUk1J",
                    "TkdfVk9JQ0UQVBIRCg1EUkFJTklOR19LSVNTEFUSEgoOREFaWkxJTkdfR0xF",
                    "QU0QVhINCglNT09OQkxBU1QQVxIOCgpQTEFZX1JPVUdIEFgSEAoMQ1JPU1Nf",
                    "UE9JU09OEFkSDwoLU0xVREdFX0JPTUIQWhIPCgtTTFVER0VfV0FWRRBbEg0K",
                    "CUdVTktfU0hPVBBcEgwKCE1VRF9TSE9UEF0SDQoJQk9ORV9DTFVCEF4SDAoI",
                    "QlVMTERPWkUQXxIMCghNVURfQk9NQhBgEg8KC0ZVUllfQ1VUVEVSEGESDAoI",
                    "QlVHX0JJVEUQYhIPCgtTSUdOQUxfQkVBTRBjEg0KCVhfU0NJU1NPUhBkEhAK",
                    "DEZMQU1FX0NIQVJHRRBlEg8KC0ZMQU1FX0JVUlNUEGYSDgoKRklSRV9CTEFT",
                    "VBBnEgkKBUJSSU5FEGgSDwoLV0FURVJfUFVMU0UQaRIJCgVTQ0FMRBBqEg4K",
                    "CkhZRFJPX1BVTVAQaxILCgdQU1lDSElDEGwSDQoJUFNZU1RSSUtFEG0SDQoJ",
                    "SUNFX1NIQVJEEG4SDAoISUNZX1dJTkQQbxIQCgxGUk9TVF9CUkVBVEgQcBIK",
                    "CgZBQlNPUkIQcRIOCgpHSUdBX0RSQUlOEHISDgoKRklSRV9QVU5DSBBzEg4K",
                    "ClNPTEFSX0JFQU0QdBIOCgpMRUFGX0JMQURFEHUSDgoKUE9XRVJfV0hJUBB2",
                    "EgoKBlNQTEFTSBB3EggKBEFDSUQQeBIOCgpBSVJfQ1VUVEVSEHkSDQoJSFVS",
                    "UklDQU5FEHoSDwoLQlJJQ0tfQlJFQUsQexIHCgNDVVQQfBIJCgVTV0lGVBB9",
                    "Eg8KC0hPUk5fQVRUQUNLEH4SCQoFU1RPTVAQfxINCghIRUFEQlVUVBCAARIP",
                    "CgpIWVBFUl9GQU5HEIEBEgkKBFNMQU0QggESDgoJQk9EWV9TTEFNEIMBEgkK",
                    "BFJFU1QQhAESDQoIU1RSVUdHTEUQhQESFAoPU0NBTERfQkxBU1RPSVNFEIYB",
                    "EhkKFEhZRFJPX1BVTVBfQkxBU1RPSVNFEIcBEg8KCldSQVBfR1JFRU4QiAES",
                    "DgoJV1JBUF9QSU5LEIkBEhUKEEZVUllfQ1VUVEVSX0ZBU1QQyAESEgoNQlVH",
                    "X0JJVEVfRkFTVBDJARIOCglCSVRFX0ZBU1QQygESFgoRU1VDS0VSX1BVTkNI",
                    "X0ZBU1QQywESFwoSRFJBR09OX0JSRUFUSF9GQVNUEMwBEhcKElRIVU5ERVJf",
                    "U0hPQ0tfRkFTVBDNARIPCgpTUEFSS19GQVNUEM4BEhIKDUxPV19LSUNLX0ZB",
                    "U1QQzwESFQoQS0FSQVRFX0NIT1BfRkFTVBDQARIPCgpFTUJFUl9GQVNUENEB",
                    "EhUKEFdJTkdfQVRUQUNLX0ZBU1QQ0gESDgoJUEVDS19GQVNUENMBEg4KCUxJ",
                    "Q0tfRkFTVBDUARIVChBTSEFET1dfQ0xBV19GQVNUENUBEhMKDlZJTkVfV0hJ",
                    "UF9GQVNUENYBEhQKD1JBWk9SX0xFQUZfRkFTVBDXARISCg1NVURfU0hPVF9G",
                    "QVNUENgBEhMKDklDRV9TSEFSRF9GQVNUENkBEhYKEUZST1NUX0JSRUFUSF9G",
                    "QVNUENoBEhYKEVFVSUNLX0FUVEFDS19GQVNUENsBEhEKDFNDUkFUQ0hfRkFT",
                    "VBDcARIQCgtUQUNLTEVfRkFTVBDdARIPCgpQT1VORF9GQVNUEN4BEg0KCENV",
                    "VF9GQVNUEN8BEhQKD1BPSVNPTl9KQUJfRkFTVBDgARIOCglBQ0lEX0ZBU1QQ",
                    "4QESFAoPUFNZQ0hPX0NVVF9GQVNUEOIBEhQKD1JPQ0tfVEhST1dfRkFTVBDj",
                    "ARIUCg9NRVRBTF9DTEFXX0ZBU1QQ5AESFgoRQlVMTEVUX1BVTkNIX0ZBU1QQ",
                    "5QESEwoOV0FURVJfR1VOX0ZBU1QQ5gESEAoLU1BMQVNIX0ZBU1QQ5wESHQoY",
                    "V0FURVJfR1VOX0ZBU1RfQkxBU1RPSVNFEOgBEhIKDU1VRF9TTEFQX0ZBU1QQ",
                    "6QESFgoRWkVOX0hFQURCVVRUX0ZBU1QQ6gESEwoOQ09ORlVTSU9OX0ZBU1QQ",
                    "6wESFgoRUE9JU09OX1NUSU5HX0ZBU1QQ7AESEAoLQlVCQkxFX0ZBU1QQ7QES",
                    "FgoRRkVJTlRfQVRUQUNLX0ZBU1QQ7gESFAoPU1RFRUxfV0lOR19GQVNUEO8B",
                    "EhMKDkZJUkVfRkFOR19GQVNUEPABEhQKD1JPQ0tfU01BU0hfRkFTVBDxASrH",
                    "BQoGSXRlbUlkEhAKDElURU1fVU5LTk9XThAAEhIKDklURU1fUE9LRV9CQUxM",
                    "EAESEwoPSVRFTV9HUkVBVF9CQUxMEAISEwoPSVRFTV9VTFRSQV9CQUxMEAMS",
                    "FAoQSVRFTV9NQVNURVJfQkFMTBAEEg8KC0lURU1fUE9USU9OEGUSFQoRSVRF",
                    "TV9TVVBFUl9QT1RJT04QZhIVChFJVEVNX0hZUEVSX1BPVElPThBnEhMKD0lU",
                    "RU1fTUFYX1BPVElPThBoEhAKC0lURU1fUkVWSVZFEMkBEhQKD0lURU1fTUFY",
                    "X1JFVklWRRDKARITCg5JVEVNX0xVQ0tZX0VHRxCtAhIaChVJVEVNX0lOQ0VO",
                    "U0VfT1JESU5BUlkQkQMSFwoSSVRFTV9JTkNFTlNFX1NQSUNZEJIDEhYKEUlU",
                    "RU1fSU5DRU5TRV9DT09MEJMDEhgKE0lURU1fSU5DRU5TRV9GTE9SQUwQlAMS",
                    "EwoOSVRFTV9UUk9ZX0RJU0sQ9QMSEgoNSVRFTV9YX0FUVEFDSxDaBBITCg5J",
                    "VEVNX1hfREVGRU5TRRDbBBITCg5JVEVNX1hfTUlSQUNMRRDcBBIUCg9JVEVN",
                    "X1JBWlpfQkVSUlkQvQUSFAoPSVRFTV9CTFVLX0JFUlJZEL4FEhUKEElURU1f",
                    "TkFOQUJfQkVSUlkQvwUSFQoQSVRFTV9XRVBBUl9CRVJSWRDABRIVChBJVEVN",
                    "X1BJTkFQX0JFUlJZEMEFEhgKE0lURU1fU1BFQ0lBTF9DQU1FUkEQoQYSIwoe",
                    "SVRFTV9JTkNVQkFUT1JfQkFTSUNfVU5MSU1JVEVEEIUHEhkKFElURU1fSU5D",
                    "VUJBVE9SX0JBU0lDEIYHEiEKHElURU1fUE9LRU1PTl9TVE9SQUdFX1VQR1JB",
                    "REUQ6QcSHgoZSVRFTV9JVEVNX1NUT1JBR0VfVVBHUkFERRDqBypiChRJbnZl",
                    "bnRvcnlVcGdyYWRlVHlwZRIRCg1VUEdSQURFX1VOU0VUEAASGQoVSU5DUkVB",
                    "U0VfSVRFTV9TVE9SQUdFEAESHAoYSU5DUkVBU0VfUE9LRU1PTl9TVE9SQUdF",
                    "EAIqPwoQRWdnSW5jdWJhdG9yVHlwZRITCg9JTkNVQkFUT1JfVU5TRVQQABIW",
                    "ChJJTkNVQkFUT1JfRElTVEFOQ0UQASrdDAoPUG9rZW1vbkZhbWlseUlkEhAK",
                    "DEZBTUlMWV9VTlNFVBAAEhQKEEZBTUlMWV9CVUxCQVNBVVIQARIVChFGQU1J",
                    "TFlfQ0hBUk1BTkRFUhAEEhMKD0ZBTUlMWV9TUVVJUlRMRRAHEhMKD0ZBTUlM",
                    "WV9DQVRFUlBJRRAKEhEKDUZBTUlMWV9XRUVETEUQDRIRCg1GQU1JTFlfUElE",
                    "R0VZEBASEgoORkFNSUxZX1JBVFRBVEEQExISCg5GQU1JTFlfU1BFQVJPVxAV",
                    "EhAKDEZBTUlMWV9FS0FOUxAXEhIKDkZBTUlMWV9QSUtBQ0hVEBkSFAoQRkFN",
                    "SUxZX1NBTkRTSFJFVxAbEhIKDkZBTUlMWV9OSURPUkFOEB0SEwoPRkFNSUxZ",
                    "X05JRE9SQU4yECASEwoPRkFNSUxZX0NMRUZBSVJZECMSEQoNRkFNSUxZX1ZV",
                    "TFBJWBAlEhUKEUZBTUlMWV9KSUdHTFlQVUZGECcSEAoMRkFNSUxZX1pVQkFU",
                    "ECkSEQoNRkFNSUxZX09ERElTSBArEhAKDEZBTUlMWV9QQVJBUxAuEhIKDkZB",
                    "TUlMWV9WRU5PTkFUEDASEgoORkFNSUxZX0RJR0xFVFQQMhIRCg1GQU1JTFlf",
                    "TUVPV1RIEDQSEgoORkFNSUxZX1BTWURVQ0sQNhIRCg1GQU1JTFlfTUFOS0VZ",
                    "EDgSFAoQRkFNSUxZX0dST1dMSVRIRRA6EhIKDkZBTUlMWV9QT0xJV0FHEDwS",
                    "DwoLRkFNSUxZX0FCUkEQPxIRCg1GQU1JTFlfTUFDSE9QEEISFQoRRkFNSUxZ",
                    "X0JFTExTUFJPVVQQRRIUChBGQU1JTFlfVEVOVEFDT09MEEgSEgoORkFNSUxZ",
                    "X0dFT0RVREUQShIRCg1GQU1JTFlfUE9OWVRBEE0SEwoPRkFNSUxZX1NMT1dQ",
                    "T0tFEE8SFAoQRkFNSUxZX01BR05FTUlURRBREhQKEEZBTUlMWV9GQVJGRVRD",
                    "SEQQUxIQCgxGQU1JTFlfRE9EVU8QVBIPCgtGQU1JTFlfU0VFTBBWEhEKDUZB",
                    "TUlMWV9HUklNRVIQWBITCg9GQU1JTFlfU0hFTExERVIQWhIRCg1GQU1JTFlf",
                    "R0FTVExZEFwSDwoLRkFNSUxZX09OSVgQXxISCg5GQU1JTFlfRFJPV1pFRRBg",
                    "EhEKDUZBTUlMWV9LUkFCQlkQYhISCg5GQU1JTFlfVk9MVE9SQhBkEhQKEEZB",
                    "TUlMWV9FWEVHR0NVVEUQZhIRCg1GQU1JTFlfQ1VCT05FEGgSFAoQRkFNSUxZ",
                    "X0hJVE1PTkxFRRBqEhUKEUZBTUlMWV9ISVRNT05DSEFOEGsSFAoQRkFNSUxZ",
                    "X0xJQ0tJVFVORxBsEhIKDkZBTUlMWV9LT0ZGSU5HEG0SEgoORkFNSUxZX1JI",
                    "WUhPUk4QbxISCg5GQU1JTFlfQ0hBTlNFWRBxEhIKDkZBTUlMWV9UQU5HRUxB",
                    "EHISFQoRRkFNSUxZX0tBTkdBU0tIQU4QcxIRCg1GQU1JTFlfSE9SU0VBEHQS",
                    "EgoORkFNSUxZX0dPTERFRU4QdhIRCg1GQU1JTFlfU1RBUllVEHgSEgoORkFN",
                    "SUxZX01SX01JTUUQehISCg5GQU1JTFlfU0NZVEhFUhB7Eg8KC0ZBTUlMWV9K",
                    "WU5YEHwSFQoRRkFNSUxZX0VMRUNUQUJVWloQfRIRCg1GQU1JTFlfTUFHTUFS",
                    "EH4SEQoNRkFNSUxZX1BJTlNJUhB/EhIKDUZBTUlMWV9UQVVST1MQgAESFAoP",
                    "RkFNSUxZX01BR0lLQVJQEIEBEhIKDUZBTUlMWV9MQVBSQVMQgwESEQoMRkFN",
                    "SUxZX0RJVFRPEIQBEhEKDEZBTUlMWV9FRVZFRRCFARITCg5GQU1JTFlfUE9S",
                    "WUdPThCJARITCg5GQU1JTFlfT01BTllURRCKARISCg1GQU1JTFlfS0FCVVRP",
                    "EIwBEhYKEUZBTUlMWV9BRVJPREFDVFlMEI4BEhMKDkZBTUlMWV9TTk9STEFY",
                    "EI8BEhQKD0ZBTUlMWV9BUlRJQ1VOTxCQARISCg1GQU1JTFlfWkFQRE9TEJEB",
                    "EhMKDkZBTUlMWV9NT0xUUkVTEJIBEhMKDkZBTUlMWV9EUkFUSU5JEJMBEhIK",
                    "DUZBTUlMWV9NRVdUV08QlgESDwoKRkFNSUxZX01FVxCXASpFChBNYXBPYmpl",
                    "Y3RzU3RhdHVzEhAKDFVOU0VUX1NUQVRVUxAAEgsKB1NVQ0NFU1MQARISCg5M",
                    "T0NBVElPTl9VTlNFVBACKiMKCEZvcnRUeXBlEgcKA0dZTRAAEg4KCkNIRUNL",
                    "UE9JTlQQASqTEAoJUG9rZW1vbklkEg0KCU1JU1NJTkdOTxAAEg0KCUJVTEJB",
                    "U0FVUhABEgsKB0lWWVNBVVIQAhIMCghWRU5VU0FVUhADEg4KCkNIQVJNRU5E",
                    "RVIQBBIOCgpDSEFSTUVMRU9OEAUSDQoJQ0hBUklaQVJEEAYSDAoIU1FVSVJU",
                    "TEUQBxINCglXQVJUT1JUTEUQCBINCglCTEFTVE9JU0UQCRIMCghDQVRFUlBJ",
                    "RRAKEgsKB01FVEFQT0QQCxIOCgpCVVRURVJGUkVFEAwSCgoGV0VFRExFEA0S",
                    "CgoGS0FLVU5BEA4SDAoIQkVFRFJJTEwQDxIKCgZQSURHRVkQEBINCglQSURH",
                    "RU9UVE8QERILCgdQSURHRU9UEBISCwoHUkFUVEFUQRATEgwKCFJBVElDQVRF",
                    "EBQSCwoHU1BFQVJPVxAVEgoKBkZFQVJPVxAWEgkKBUVLQU5TEBcSCQoFQVJC",
                    "T0sQGBILCgdQSUtBQ0hVEBkSCgoGUkFJQ0hVEBoSDQoJU0FORFNIUkVXEBsS",
                    "DAoIU0FORExBU0gQHBISCg5OSURPUkFOX0ZFTUFMRRAdEgwKCE5JRE9SSU5B",
                    "EB4SDQoJTklET1FVRUVOEB8SEAoMTklET1JBTl9NQUxFECASDAoITklET1JJ",
                    "Tk8QIRIMCghOSURPS0lORxAiEgsKB0NMRUZBUlkQIxIMCghDTEVGQUJMRRAk",
                    "EgoKBlZVTFBJWBAlEg0KCU5JTkVUQUxFUxAmEg4KCkpJR0dMWVBVRkYQJxIO",
                    "CgpXSUdHTFlUVUZGECgSCQoFWlVCQVQQKRIKCgZHT0xCQVQQKhIKCgZPRERJ",
                    "U0gQKxIJCgVHTE9PTRAsEg0KCVZJTEVQTFVNRRAtEgkKBVBBUkFTEC4SDAoI",
                    "UEFSQVNFQ1QQLxILCgdWRU5PTkFUEDASDAoIVkVOT01PVEgQMRILCgdESUdM",
                    "RVRUEDISCwoHRFVHVFJJTxAzEgoKBk1FT1dUSBA0EgsKB1BFUlNJQU4QNRIL",
                    "CgdQU1lEVUNLEDYSCwoHR09MRFVDSxA3EgoKBk1BTktFWRA4EgwKCFBSSU1F",
                    "QVBFEDkSDQoJR1JPV0xJVEhFEDoSDAoIQVJDQU5JTkUQOxILCgdQT0xJV0FH",
                    "EDwSDQoJUE9MSVdISVJMED0SDQoJUE9MSVdSQVRIED4SCAoEQUJSQRA/EgsK",
                    "B0tBREFCUkEQQBINCglBTEFLSEFaQU0QQRIKCgZNQUNIT1AQQhILCgdNQUNI",
                    "T0tFEEMSCwoHTUFDSEFNUBBEEg4KCkJFTExTUFJPVVQQRRIOCgpXRUVQSU5C",
                    "RUxMEEYSDwoLVklDVFJFRUJFTEwQRxINCglURU5UQUNPT0wQSBIOCgpURU5U",
                    "QUNSVUVMEEkSCwoHR0VPRFVHRRBKEgwKCEdSQVZFTEVSEEsSCQoFR09MRU0Q",
                    "TBIKCgZQT05ZVEEQTRIMCghSQVBJREFTSBBOEgwKCFNMT1dQT0tFEE8SCwoH",
                    "U0xPV0JSTxBQEg0KCU1BR05FTUlURRBREgwKCE1BR05FVE9OEFISDQoJRkFS",
                    "RkVUQ0hEEFMSCQoFRE9EVU8QVBIKCgZET0RSSU8QVRIICgRTRUVMEFYSCwoH",
                    "REVXR09ORxBXEgoKBkdSSU1FUhBYEgcKA01VSxBZEgwKCFNIRUxMREVSEFoS",
                    "DAoIQ0xPWVNURVIQWxIKCgZHQVNUTFkQXBILCgdIQVVOVEVSEF0SCgoGR0VO",
                    "R0FSEF4SCAoET05JWBBfEgsKB0RST1daRUUQYBIJCgVIWVBOTxBhEgoKBktS",
                    "QUJCWRBiEgsKB0tJTkdMRVIQYxILCgdWT0xUT1JCEGQSDQoJRUxFQ1RST0RF",
                    "EGUSDQoJRVhFR0dDVVRFEGYSDQoJRVhFR0dVVE9SEGcSCgoGQ1VCT05FEGgS",
                    "CwoHTUFST1dBSxBpEg0KCUhJVE1PTkxFRRBqEg4KCkhJVE1PTkNIQU4QaxIN",
                    "CglMSUNLSVRVTkcQbBILCgdLT0ZGSU5HEG0SCwoHV0VFWklORxBuEgsKB1JI",
                    "WUhPUk4QbxIKCgZSSFlET04QcBILCgdDSEFOU0VZEHESCwoHVEFOR0VMQRBy",
                    "Eg4KCktBTkdBU0tIQU4QcxIKCgZIT1JTRUEQdBIKCgZTRUFEUkEQdRILCgdH",
                    "T0xERUVOEHYSCwoHU0VBS0lORxB3EgoKBlNUQVJZVRB4EgsKB1NUQVJNSUUQ",
                    "eRILCgdNUl9NSU1FEHoSCwoHU0NZVEhFUhB7EggKBEpZTlgQfBIOCgpFTEVD",
                    "VEFCVVpaEH0SCgoGTUFHTUFSEH4SCgoGUElOU0lSEH8SCwoGVEFVUk9TEIAB",
                    "Eg0KCE1BR0lLQVJQEIEBEg0KCEdZQVJBRE9TEIIBEgsKBkxBUFJBUxCDARIK",
                    "CgVESVRUTxCEARIKCgVFRVZFRRCFARINCghWQVBPUkVPThCGARIMCgdKT0xU",
                    "RU9OEIcBEgwKB0ZMQVJFT04QiAESDAoHUE9SWUdPThCJARIMCgdPTUFOWVRF",
                    "EIoBEgwKB09NQVNUQVIQiwESCwoGS0FCVVRPEIwBEg0KCEtBQlVUT1BTEI0B",
                    "Eg8KCkFFUk9EQUNUWUwQjgESDAoHU05PUkxBWBCPARINCghBUlRJQ1VOTxCQ",
                    "ARILCgZaQVBET1MQkQESDAoHTU9MVFJFUxCSARIMCgdEUkFUSU5JEJMBEg4K",
                    "CURSQUdPTkFJUhCUARIOCglEUkFHT05JVEUQlQESCwoGTUVXVFdPEJYBEggK",
                    "A01FVxCXASpCCgtGb3J0U3BvbnNvchIRCg1VTlNFVF9TUE9OU09SEAASDQoJ",
                    "TUNET05BTERTEAESEQoNUE9LRU1PTl9TVE9SRRACKjMKEUZvcnRSZW5kZXJp",
                    "bmdUeXBlEgsKB0RFRkFVTFQQABIRCg1JTlRFUk5BTF9URVNUEAEqsgIKCEl0",
                    "ZW1UeXBlEhIKDklURU1fVFlQRV9OT05FEAASFgoSSVRFTV9UWVBFX1BPS0VC",
                    "QUxMEAESFAoQSVRFTV9UWVBFX1BPVElPThACEhQKEElURU1fVFlQRV9SRVZJ",
                    "VkUQAxIRCg1JVEVNX1RZUEVfTUFQEAQSFAoQSVRFTV9UWVBFX0JBVFRMRRAF",
                    "EhIKDklURU1fVFlQRV9GT09EEAYSFAoQSVRFTV9UWVBFX0NBTUVSQRAHEhIK",
                    "DklURU1fVFlQRV9ESVNLEAgSFwoTSVRFTV9UWVBFX0lOQ1VCQVRPUhAJEhUK",
                    "EUlURU1fVFlQRV9JTkNFTlNFEAoSFgoSSVRFTV9UWVBFX1hQX0JPT1NUEAsS",
                    "HwobSVRFTV9UWVBFX0lOVkVOVE9SWV9VUEdSQURFEAwq1gIKDEl0ZW1DYXRl",
                    "Z29yeRIWChJJVEVNX0NBVEVHT1JZX05PTkUQABIaChZJVEVNX0NBVEVHT1JZ",
                    "X1BPS0VCQUxMEAESFgoSSVRFTV9DQVRFR09SWV9GT09EEAISGgoWSVRFTV9D",
                    "QVRFR09SWV9NRURJQ0lORRADEhcKE0lURU1fQ0FURUdPUllfQk9PU1QQBBIa",
                    "ChZJVEVNX0NBVEVHT1JZX1VUSUxJVEVTEAUSGAoUSVRFTV9DQVRFR09SWV9D",
                    "QU1FUkEQBhIWChJJVEVNX0NBVEVHT1JZX0RJU0sQBxIbChdJVEVNX0NBVEVH",
                    "T1JZX0lOQ1VCQVRPUhAIEhkKFUlURU1fQ0FURUdPUllfSU5DRU5TRRAJEhoK",
                    "FklURU1fQ0FURUdPUllfWFBfQk9PU1QQChIjCh9JVEVNX0NBVEVHT1JZX0lO",
                    "VkVOVE9SWV9VUEdSQURFEAsqmAQKCkl0ZW1FZmZlY3QSFAoQSVRFTV9FRkZF",
                    "Q1RfTk9ORRAAEhwKF0lURU1fRUZGRUNUX0NBUF9OT19GTEVFEOgHEiAKG0lU",
                    "RU1fRUZGRUNUX0NBUF9OT19NT1ZFTUVOVBDqBxIeChlJVEVNX0VGRkVDVF9D",
                    "QVBfTk9fVEhSRUFUEOsHEh8KGklURU1fRUZGRUNUX0NBUF9UQVJHRVRfTUFY",
                    "EOwHEiAKG0lURU1fRUZGRUNUX0NBUF9UQVJHRVRfU0xPVxDtBxIhChxJVEVN",
                    "X0VGRkVDVF9DQVBfQ0hBTkNFX05JR0hUEO4HEiMKHklURU1fRUZGRUNUX0NB",
                    "UF9DSEFOQ0VfVFJBSU5FUhDvBxInCiJJVEVNX0VGRkVDVF9DQVBfQ0hBTkNF",
                    "X0ZJUlNUX1RIUk9XEPAHEiIKHUlURU1fRUZGRUNUX0NBUF9DSEFOQ0VfTEVH",
                    "RU5EEPEHEiEKHElURU1fRUZGRUNUX0NBUF9DSEFOQ0VfSEVBVlkQ8gcSIgod",
                    "SVRFTV9FRkZFQ1RfQ0FQX0NIQU5DRV9SRVBFQVQQ8wcSJwoiSVRFTV9FRkZF",
                    "Q1RfQ0FQX0NIQU5DRV9NVUxUSV9USFJPVxD0BxIiCh1JVEVNX0VGRkVDVF9D",
                    "QVBfQ0hBTkNFX0FMV0FZUxD1BxIoCiNJVEVNX0VGRkVDVF9DQVBfQ0hBTkNF",
                    "X1NJTkdMRV9USFJPVxD2ByrsBQoMQWN0aXZpdHlUeXBlEhQKEEFDVElWSVRZ",
                    "X1VOS05PV04QABIaChZBQ1RJVklUWV9DQVRDSF9QT0tFTU9OEAESIQodQUNU",
                    "SVZJVFlfQ0FUQ0hfTEVHRU5EX1BPS0VNT04QAhIZChVBQ1RJVklUWV9GTEVF",
                    "X1BPS0VNT04QAxIYChRBQ1RJVklUWV9ERUZFQVRfRk9SVBAEEhsKF0FDVElW",
                    "SVRZX0VWT0xWRV9QT0tFTU9OEAUSFgoSQUNUSVZJVFlfSEFUQ0hfRUdHEAYS",
                    "FAoQQUNUSVZJVFlfV0FMS19LTRAHEh4KGkFDVElWSVRZX1BPS0VERVhfRU5U",
                    "UllfTkVXEAgSHgoaQUNUSVZJVFlfQ0FUQ0hfRklSU1RfVEhST1cQCRIdChlB",
                    "Q1RJVklUWV9DQVRDSF9OSUNFX1RIUk9XEAoSHgoaQUNUSVZJVFlfQ0FUQ0hf",
                    "R1JFQVRfVEhST1cQCxIiCh5BQ1RJVklUWV9DQVRDSF9FWENFTExFTlRfVEhS",
                    "T1cQDBIcChhBQ1RJVklUWV9DQVRDSF9DVVJWRUJBTEwQDRIlCiFBQ1RJVklU",
                    "WV9DQVRDSF9GSVJTVF9DQVRDSF9PRl9EQVkQDhIcChhBQ1RJVklUWV9DQVRD",
                    "SF9NSUxFU1RPTkUQDxIaChZBQ1RJVklUWV9UUkFJTl9QT0tFTU9OEBASGAoU",
                    "QUNUSVZJVFlfU0VBUkNIX0ZPUlQQERIcChhBQ1RJVklUWV9SRUxFQVNFX1BP",
                    "S0VNT04QEhIiCh5BQ1RJVklUWV9IQVRDSF9FR0dfU01BTExfQk9OVVMQExIj",
                    "Ch9BQ1RJVklUWV9IQVRDSF9FR0dfTUVESVVNX0JPTlVTEBQSIgoeQUNUSVZJ",
                    "VFlfSEFUQ0hfRUdHX0xBUkdFX0JPTlVTEBUSIAocQUNUSVZJVFlfREVGRUFU",
                    "X0dZTV9ERUZFTkRFUhAWEh4KGkFDVElWSVRZX0RFRkVBVF9HWU1fTEVBREVS",
                    "EBcqoQcKCUJhZGdlVHlwZRIPCgtCQURHRV9VTlNFVBAAEhMKD0JBREdFX1RS",
                    "QVZFTF9LTRABEhkKFUJBREdFX1BPS0VERVhfRU5UUklFUxACEhcKE0JBREdF",
                    "X0NBUFRVUkVfVE9UQUwQAxIXChNCQURHRV9ERUZFQVRFRF9GT1JUEAQSFwoT",
                    "QkFER0VfRVZPTFZFRF9UT1RBTBAFEhcKE0JBREdFX0hBVENIRURfVE9UQUwQ",
                    "BhIbChdCQURHRV9FTkNPVU5URVJFRF9UT1RBTBAHEhsKF0JBREdFX1BPS0VT",
                    "VE9QU19WSVNJVEVEEAgSGgoWQkFER0VfVU5JUVVFX1BPS0VTVE9QUxAJEhkK",
                    "FUJBREdFX1BPS0VCQUxMX1RIUk9XThAKEhYKEkJBREdFX0JJR19NQUdJS0FS",
                    "UBALEhgKFEJBREdFX0RFUExPWUVEX1RPVEFMEAwSGwoXQkFER0VfQkFUVExF",
                    "X0FUVEFDS19XT04QDRIdChlCQURHRV9CQVRUTEVfVFJBSU5JTkdfV09OEA4S",
                    "GwoXQkFER0VfQkFUVExFX0RFRkVORF9XT04QDxIZChVCQURHRV9QUkVTVElH",
                    "RV9SQUlTRUQQEBIaChZCQURHRV9QUkVTVElHRV9EUk9QUEVEEBESFQoRQkFE",
                    "R0VfVFlQRV9OT1JNQUwQEhIXChNCQURHRV9UWVBFX0ZJR0hUSU5HEBMSFQoR",
                    "QkFER0VfVFlQRV9GTFlJTkcQFBIVChFCQURHRV9UWVBFX1BPSVNPThAVEhUK",
                    "EUJBREdFX1RZUEVfR1JPVU5EEBYSEwoPQkFER0VfVFlQRV9ST0NLEBcSEgoO",
                    "QkFER0VfVFlQRV9CVUcQGBIUChBCQURHRV9UWVBFX0dIT1NUEBkSFAoQQkFE",
                    "R0VfVFlQRV9TVEVFTBAaEhMKD0JBREdFX1RZUEVfRklSRRAbEhQKEEJBREdF",
                    "X1RZUEVfV0FURVIQHBIUChBCQURHRV9UWVBFX0dSQVNTEB0SFwoTQkFER0Vf",
                    "VFlQRV9FTEVDVFJJQxAeEhYKEkJBREdFX1RZUEVfUFNZQ0hJQxAfEhIKDkJB",
                    "REdFX1RZUEVfSUNFECASFQoRQkFER0VfVFlQRV9EUkFHT04QIRITCg9CQURH",
                    "RV9UWVBFX0RBUksQIhIUChBCQURHRV9UWVBFX0ZBSVJZECMSFwoTQkFER0Vf",
                    "U01BTExfUkFUVEFUQRAkEhEKDUJBREdFX1BJS0FDSFUQJSqUAQoTSG9sb0lh",
                    "cEl0ZW1DYXRlZ29yeRIVChFJQVBfQ0FURUdPUllfTk9ORRAAEhcKE0lBUF9D",
                    "QVRFR09SWV9CVU5ETEUQARIWChJJQVBfQ0FURUdPUllfSVRFTVMQAhIZChVJ",
                    "QVBfQ0FURUdPUllfVVBHUkFERVMQAxIaChZJQVBfQ0FURUdPUllfUE9LRUNP",
                    "SU5TEAQqlgEKE0NhbWVyYUludGVycG9sYXRpb24SEgoOQ0FNX0lOVEVSUF9D",
                    "VVQQABIVChFDQU1fSU5URVJQX0xJTkVBUhABEhUKEUNBTV9JTlRFUlBfU01P",
                    "T1RIEAISJQohQ0FNX0lOVEVSUF9TTU9PVEhfUk9UX0xJTkVBUl9NT1ZFEAMS",
                    "FgoSQ0FNX0lOVEVSUF9ERVBFTkRTEAQq/AMKDENhbWVyYVRhcmdldBIXChND",
                    "QU1fVEFSR0VUX0FUVEFDS0VSEAASHAoYQ0FNX1RBUkdFVF9BVFRBQ0tFUl9F",
                    "REdFEAESHgoaQ0FNX1RBUkdFVF9BVFRBQ0tFUl9HUk9VTkQQAhIXChNDQU1f",
                    "VEFSR0VUX0RFRkVOREVSEAMSHAoYQ0FNX1RBUkdFVF9ERUZFTkRFUl9FREdF",
                    "EAQSHgoaQ0FNX1RBUkdFVF9ERUZFTkRFUl9HUk9VTkQQBRIgChxDQU1fVEFS",
                    "R0VUX0FUVEFDS0VSX0RFRkVOREVSEAYSJQohQ0FNX1RBUkdFVF9BVFRBQ0tF",
                    "Ul9ERUZFTkRFUl9FREdFEAcSIAocQ0FNX1RBUkdFVF9ERUZFTkRFUl9BVFRB",
                    "Q0tFUhAIEiUKIUNBTV9UQVJHRVRfREVGRU5ERVJfQVRUQUNLRVJfRURHRRAJ",
                    "EicKI0NBTV9UQVJHRVRfQVRUQUNLRVJfREVGRU5ERVJfTUlSUk9SEAsSKQol",
                    "Q0FNX1RBUkdFVF9TSE9VTERFUl9BVFRBQ0tFUl9ERUZFTkRFUhAMEjAKLENB",
                    "TV9UQVJHRVRfU0hPVUxERVJfQVRUQUNLRVJfREVGRU5ERVJfTUlSUk9SEA0S",
                    "JgoiQ0FNX1RBUkdFVF9BVFRBQ0tFUl9ERUZFTkRFUl9XT1JMRBAOKtoDCgtQ",
                    "b2tlbW9uVHlwZRIVChFQT0tFTU9OX1RZUEVfTk9ORRAAEhcKE1BPS0VNT05f",
                    "VFlQRV9OT1JNQUwQARIZChVQT0tFTU9OX1RZUEVfRklHSFRJTkcQAhIXChNQ",
                    "T0tFTU9OX1RZUEVfRkxZSU5HEAMSFwoTUE9LRU1PTl9UWVBFX1BPSVNPThAE",
                    "EhcKE1BPS0VNT05fVFlQRV9HUk9VTkQQBRIVChFQT0tFTU9OX1RZUEVfUk9D",
                    "SxAGEhQKEFBPS0VNT05fVFlQRV9CVUcQBxIWChJQT0tFTU9OX1RZUEVfR0hP",
                    "U1QQCBIWChJQT0tFTU9OX1RZUEVfU1RFRUwQCRIVChFQT0tFTU9OX1RZUEVf",
                    "RklSRRAKEhYKElBPS0VNT05fVFlQRV9XQVRFUhALEhYKElBPS0VNT05fVFlQ",
                    "RV9HUkFTUxAMEhkKFVBPS0VNT05fVFlQRV9FTEVDVFJJQxANEhgKFFBPS0VN",
                    "T05fVFlQRV9QU1lDSElDEA4SFAoQUE9LRU1PTl9UWVBFX0lDRRAPEhcKE1BP",
                    "S0VNT05fVFlQRV9EUkFHT04QEBIVChFQT0tFTU9OX1RZUEVfREFSSxAREhYK",
                    "ElBPS0VNT05fVFlQRV9GQUlSWRASKq0BChNQb2tlbW9uTW92ZW1lbnRUeXBl",
                    "EhMKD01PVkVNRU5UX1NUQVRJQxAAEhEKDU1PVkVNRU5UX0pVTVAQARIVChFN",
                    "T1ZFTUVOVF9WRVJUSUNBTBACEhQKEE1PVkVNRU5UX1BTWUNISUMQAxIVChFN",
                    "T1ZFTUVOVF9FTEVDVFJJQxAEEhMKD01PVkVNRU5UX0ZMWUlORxAFEhUKEU1P",
                    "VkVNRU5UX0hPVkVSSU5HEAYqNQoMUG9rZW1vbkNsYXNzEgoKBk5PUk1BTBAA",
                    "Eg0KCUxFR0VOREFSWRABEgoKBk1ZVEhJQxACYgZwcm90bzM="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { },
                new pbr::GeneratedClrTypeInfo(
                    new[]
                    {
                        typeof(global::AllEnum.RpcDirection), typeof(global::AllEnum.TeamColor),
                        typeof(global::AllEnum.RequestMethod), typeof(global::AllEnum.PokemonMove),
                        typeof(global::AllEnum.ItemId), typeof(global::AllEnum.InventoryUpgradeType),
                        typeof(global::AllEnum.EggIncubatorType), typeof(global::AllEnum.PokemonFamilyId),
                        typeof(global::AllEnum.MapObjectsStatus), typeof(global::AllEnum.FortType),
                        typeof(global::AllEnum.PokemonId), typeof(global::AllEnum.FortSponsor),
                        typeof(global::AllEnum.FortRenderingType), typeof(global::AllEnum.ItemType),
                        typeof(global::AllEnum.ItemCategory), typeof(global::AllEnum.ItemEffect),
                        typeof(global::AllEnum.ActivityType), typeof(global::AllEnum.BadgeType),
                        typeof(global::AllEnum.HoloIapItemCategory), typeof(global::AllEnum.CameraInterpolation),
                        typeof(global::AllEnum.CameraTarget), typeof(global::AllEnum.PokemonType),
                        typeof(global::AllEnum.PokemonMovementType), typeof(global::AllEnum.PokemonClass),
                    }, null));
        }

        #endregion
    }

    #region Enums

    public enum RpcDirection
    {
        [pbr::OriginalName("UNKNOWN")]
        Unknown = 0,
        [pbr::OriginalName("RESPONSE")]
        Response = 1,
        [pbr::OriginalName("REQUEST")]
        Request = 2,
    }

    public enum TeamColor
    {
        [pbr::OriginalName("NEUTRAL")]
        Neutral = 0,
        [pbr::OriginalName("BLUE")]
        Blue = 1,
        [pbr::OriginalName("RED")]
        Red = 2,
        [pbr::OriginalName("YELLOW")]
        Yellow = 3,
    }

    public enum RequestMethod
    {
        [pbr::OriginalName("METHOD_UNSET")]
        MethodUnset = 0,
        [pbr::OriginalName("PLAYER_UPDATE")]
        PlayerUpdate = 1,
        [pbr::OriginalName("GET_PLAYER")]
        GetPlayer = 2,
        [pbr::OriginalName("GET_INVENTORY")]
        GetInventory = 4,
        [pbr::OriginalName("DOWNLOAD_SETTINGS")]
        DownloadSettings = 5,
        [pbr::OriginalName("DOWNLOAD_ITEM_TEMPLATES")]
        DownloadItemTemplates = 6,
        [pbr::OriginalName("DOWNLOAD_REMOTE_CONFIG_VERSION")]
        DownloadRemoteConfigVersion = 7,
        [pbr::OriginalName("FORT_SEARCH")]
        FortSearch = 101,
        [pbr::OriginalName("ENCOUNTER")]
        Encounter = 102,
        [pbr::OriginalName("CATCH_POKEMON")]
        CatchPokemon = 103,
        [pbr::OriginalName("FORT_DETAILS")]
        FortDetails = 104,
        [pbr::OriginalName("ITEM_USE")]
        ItemUse = 105,
        [pbr::OriginalName("GET_MAP_OBJECTS")]
        GetMapObjects = 106,
        [pbr::OriginalName("FORT_DEPLOY_POKEMON")]
        FortDeployPokemon = 110,
        [pbr::OriginalName("FORT_RECALL_POKEMON")]
        FortRecallPokemon = 111,
        [pbr::OriginalName("RELEASE_POKEMON")]
        ReleasePokemon = 112,
        [pbr::OriginalName("USE_ITEM_POTION")]
        UseItemPotion = 113,
        [pbr::OriginalName("USE_ITEM_CAPTURE")]
        UseItemCapture = 114,
        [pbr::OriginalName("USE_ITEM_FLEE")]
        UseItemFlee = 115,
        [pbr::OriginalName("USE_ITEM_REVIVE")]
        UseItemRevive = 116,
        [pbr::OriginalName("TRADE_SEARCH")]
        TradeSearch = 117,
        [pbr::OriginalName("TRADE_OFFER")]
        TradeOffer = 118,
        [pbr::OriginalName("TRADE_RESPONSE")]
        TradeResponse = 119,
        [pbr::OriginalName("TRADE_RESULT")]
        TradeResult = 120,
        [pbr::OriginalName("GET_PLAYER_PROFILE")]
        GetPlayerProfile = 121,
        [pbr::OriginalName("GET_ITEM_PACK")]
        GetItemPack = 122,
        [pbr::OriginalName("BUY_ITEM_PACK")]
        BuyItemPack = 123,
        [pbr::OriginalName("BUY_GEM_PACK")]
        BuyGemPack = 124,
        [pbr::OriginalName("EVOLVE_POKEMON")]
        EvolvePokemon = 125,
        [pbr::OriginalName("GET_HATCHED_EGGS")]
        GetHatchedEggs = 126,
        [pbr::OriginalName("ENCOUNTER_TUTORIAL_COMPLETE")]
        EncounterTutorialComplete = 127,
        [pbr::OriginalName("LEVEL_UP_REWARDS")]
        LevelUpRewards = 128,
        [pbr::OriginalName("CHECK_AWARDED_BADGES")]
        CheckAwardedBadges = 129,
        [pbr::OriginalName("USE_ITEM_GYM")]
        UseItemGym = 133,
        [pbr::OriginalName("GET_GYM_DETAILS")]
        GetGymDetails = 134,
        [pbr::OriginalName("START_GYM_BATTLE")]
        StartGymBattle = 135,
        [pbr::OriginalName("ATTACK_GYM")]
        AttackGym = 136,
        [pbr::OriginalName("RECYCLE_INVENTORY_ITEM")]
        RecycleInventoryItem = 137,
        [pbr::OriginalName("COLLECT_DAILY_BONUS")]
        CollectDailyBonus = 138,
        [pbr::OriginalName("USE_ITEM_XP_BOOST")]
        UseItemXpBoost = 139,
        [pbr::OriginalName("USE_ITEM_EGG_INCUBATOR")]
        UseItemEggIncubator = 140,
        [pbr::OriginalName("USE_INCENSE")]
        UseIncense = 141,
        [pbr::OriginalName("GET_INCENSE_POKEMON")]
        GetIncensePokemon = 142,
        [pbr::OriginalName("INCENSE_ENCOUNTER")]
        IncenseEncounter = 143,
        [pbr::OriginalName("ADD_FORT_MODIFIER")]
        AddFortModifier = 144,
        [pbr::OriginalName("DISK_ENCOUNTER")]
        DiskEncounter = 145,
        [pbr::OriginalName("COLLECT_DAILY_DEFENDER_BONUS")]
        CollectDailyDefenderBonus = 146,
        [pbr::OriginalName("UPGRADE_POKEMON")]
        UpgradePokemon = 147,
        [pbr::OriginalName("SET_FAVORITE_POKEMON")]
        SetFavoritePokemon = 148,
        [pbr::OriginalName("NICKNAME_POKEMON")]
        NicknamePokemon = 149,
        [pbr::OriginalName("EQUIP_BADGE")]
        EquipBadge = 150,
        [pbr::OriginalName("SET_CONTACT_SETTINGS")]
        SetContactSettings = 151,
        [pbr::OriginalName("GET_ASSET_DIGEST")]
        GetAssetDigest = 300,
        [pbr::OriginalName("GET_DOWNLOAD_URLS")]
        GetDownloadUrls = 301,
        [pbr::OriginalName("GET_SUGGESTED_CODENAMES")]
        GetSuggestedCodenames = 401,
        [pbr::OriginalName("CHECK_CODENAME_AVAILABLE")]
        CheckCodenameAvailable = 402,
        [pbr::OriginalName("CLAIM_CODENAME")]
        ClaimCodename = 403,
        [pbr::OriginalName("SET_AVATAR")]
        SetAvatar = 404,
        [pbr::OriginalName("SET_PLAYER_TEAM")]
        SetPlayerTeam = 405,
        [pbr::OriginalName("MARK_TUTORIAL_COMPLETE")]
        MarkTutorialComplete = 406,
        [pbr::OriginalName("LOAD_SPAWN_POINTS")]
        LoadSpawnPoints = 500,
        [pbr::OriginalName("ECHO")]
        Echo = 666,
        [pbr::OriginalName("DEBUG_UPDATE_INVENTORY")]
        DebugUpdateInventory = 700,
        [pbr::OriginalName("DEBUG_DELETE_PLAYER")]
        DebugDeletePlayer = 701,
        [pbr::OriginalName("SFIDA_REGISTRATION")]
        SfidaRegistration = 800,
        [pbr::OriginalName("SFIDA_ACTION_LOG")]
        SfidaActionLog = 801,
        [pbr::OriginalName("SFIDA_CERTIFICATION")]
        SfidaCertification = 802,
        [pbr::OriginalName("SFIDA_UPDATE")]
        SfidaUpdate = 803,
        [pbr::OriginalName("SFIDA_ACTION")]
        SfidaAction = 804,
        [pbr::OriginalName("SFIDA_DOWSER")]
        SfidaDowser = 805,
        [pbr::OriginalName("SFIDA_CAPTURE")]
        SfidaCapture = 806,
    }

    public enum PokemonMove
    {
        [pbr::OriginalName("MOVE_UNSET")]
        MoveUnset = 0,
        [pbr::OriginalName("THUNDER_SHOCK")]
        ThunderShock = 1,
        [pbr::OriginalName("QUICK_ATTACK")]
        QuickAttack = 2,
        [pbr::OriginalName("SCRATCH")]
        Scratch = 3,
        [pbr::OriginalName("EMBER")]
        Ember = 4,
        [pbr::OriginalName("VINE_WHIP")]
        VineWhip = 5,
        [pbr::OriginalName("TACKLE")]
        Tackle = 6,
        [pbr::OriginalName("RAZOR_LEAF")]
        RazorLeaf = 7,
        [pbr::OriginalName("TAKE_DOWN")]
        TakeDown = 8,
        [pbr::OriginalName("WATER_GUN")]
        WaterGun = 9,
        [pbr::OriginalName("BITE")]
        Bite = 10,
        [pbr::OriginalName("POUND")]
        Pound = 11,
        [pbr::OriginalName("DOUBLE_SLAP")]
        DoubleSlap = 12,
        [pbr::OriginalName("WRAP")]
        Wrap = 13,
        [pbr::OriginalName("HYPER_BEAM")]
        HyperBeam = 14,
        [pbr::OriginalName("LICK")]
        Lick = 15,
        [pbr::OriginalName("DARK_PULSE")]
        DarkPulse = 16,
        [pbr::OriginalName("SMOG")]
        Smog = 17,
        [pbr::OriginalName("SLUDGE")]
        Sludge = 18,
        [pbr::OriginalName("METAL_CLAW")]
        MetalClaw = 19,
        [pbr::OriginalName("VICE_GRIP")]
        ViceGrip = 20,
        [pbr::OriginalName("FLAME_WHEEL")]
        FlameWheel = 21,
        [pbr::OriginalName("MEGAHORN")]
        Megahorn = 22,
        [pbr::OriginalName("WING_ATTACK")]
        WingAttack = 23,
        [pbr::OriginalName("FLAMETHROWER")]
        Flamethrower = 24,
        [pbr::OriginalName("SUCKER_PUNCH")]
        SuckerPunch = 25,
        [pbr::OriginalName("DIG")]
        Dig = 26,
        [pbr::OriginalName("LOW_KICK")]
        LowKick = 27,
        [pbr::OriginalName("CROSS_CHOP")]
        CrossChop = 28,
        [pbr::OriginalName("PSYCHO_CUT")]
        PsychoCut = 29,
        [pbr::OriginalName("PSYBEAM")]
        Psybeam = 30,
        [pbr::OriginalName("EARTHQUAKE")]
        Earthquake = 31,
        [pbr::OriginalName("STONE_EDGE")]
        StoneEdge = 32,
        [pbr::OriginalName("ICE_PUNCH")]
        IcePunch = 33,
        [pbr::OriginalName("HEART_STAMP")]
        HeartStamp = 34,
        [pbr::OriginalName("DISCHARGE")]
        Discharge = 35,
        [pbr::OriginalName("FLASH_CANNON")]
        FlashCannon = 36,
        [pbr::OriginalName("PECK")]
        Peck = 37,
        [pbr::OriginalName("DRILL_PECK")]
        DrillPeck = 38,
        [pbr::OriginalName("ICE_BEAM")]
        IceBeam = 39,
        [pbr::OriginalName("BLIZZARD")]
        Blizzard = 40,
        [pbr::OriginalName("AIR_SLASH")]
        AirSlash = 41,
        [pbr::OriginalName("HEAT_WAVE")]
        HeatWave = 42,
        [pbr::OriginalName("TWINEEDLE")]
        Twineedle = 43,
        [pbr::OriginalName("POISON_JAB")]
        PoisonJab = 44,
        [pbr::OriginalName("AERIAL_ACE")]
        AerialAce = 45,
        [pbr::OriginalName("DRILL_RUN")]
        DrillRun = 46,
        [pbr::OriginalName("PETAL_BLIZZARD")]
        PetalBlizzard = 47,
        [pbr::OriginalName("MEGA_DRAIN")]
        MegaDrain = 48,
        [pbr::OriginalName("BUG_BUZZ")]
        BugBuzz = 49,
        [pbr::OriginalName("POISON_FANG")]
        PoisonFang = 50,
        [pbr::OriginalName("NIGHT_SLASH")]
        NightSlash = 51,
        [pbr::OriginalName("SLASH")]
        Slash = 52,
        [pbr::OriginalName("BUBBLE_BEAM")]
        BubbleBeam = 53,
        [pbr::OriginalName("SUBMISSION")]
        Submission = 54,
        [pbr::OriginalName("KARATE_CHOP")]
        KarateChop = 55,
        [pbr::OriginalName("LOW_SWEEP")]
        LowSweep = 56,
        [pbr::OriginalName("AQUA_JET")]
        AquaJet = 57,
        [pbr::OriginalName("AQUA_TAIL")]
        AquaTail = 58,
        [pbr::OriginalName("SEED_BOMB")]
        SeedBomb = 59,
        [pbr::OriginalName("PSYSHOCK")]
        Psyshock = 60,
        [pbr::OriginalName("ROCK_THROW")]
        RockThrow = 61,
        [pbr::OriginalName("ANCIENT_POWER")]
        AncientPower = 62,
        [pbr::OriginalName("ROCK_TOMB")]
        RockTomb = 63,
        [pbr::OriginalName("ROCK_SLIDE")]
        RockSlide = 64,
        [pbr::OriginalName("POWER_GEM")]
        PowerGem = 65,
        [pbr::OriginalName("SHADOW_SNEAK")]
        ShadowSneak = 66,
        [pbr::OriginalName("SHADOW_PUNCH")]
        ShadowPunch = 67,
        [pbr::OriginalName("SHADOW_CLAW")]
        ShadowClaw = 68,
        [pbr::OriginalName("OMINOUS_WIND")]
        OminousWind = 69,
        [pbr::OriginalName("SHADOW_BALL")]
        ShadowBall = 70,
        [pbr::OriginalName("BULLET_PUNCH")]
        BulletPunch = 71,
        [pbr::OriginalName("MAGNET_BOMB")]
        MagnetBomb = 72,
        [pbr::OriginalName("STEEL_WING")]
        SteelWing = 73,
        [pbr::OriginalName("IRON_HEAD")]
        IronHead = 74,
        [pbr::OriginalName("PARABOLIC_CHARGE")]
        ParabolicCharge = 75,
        [pbr::OriginalName("SPARK")]
        Spark = 76,
        [pbr::OriginalName("THUNDER_PUNCH")]
        ThunderPunch = 77,
        [pbr::OriginalName("THUNDER")]
        Thunder = 78,
        [pbr::OriginalName("THUNDERBOLT")]
        Thunderbolt = 79,
        [pbr::OriginalName("TWISTER")]
        Twister = 80,
        [pbr::OriginalName("DRAGON_BREATH")]
        DragonBreath = 81,
        [pbr::OriginalName("DRAGON_PULSE")]
        DragonPulse = 82,
        [pbr::OriginalName("DRAGON_CLAW")]
        DragonClaw = 83,
        [pbr::OriginalName("DISARMING_VOICE")]
        DisarmingVoice = 84,
        [pbr::OriginalName("DRAINING_KISS")]
        DrainingKiss = 85,
        [pbr::OriginalName("DAZZLING_GLEAM")]
        DazzlingGleam = 86,
        [pbr::OriginalName("MOONBLAST")]
        Moonblast = 87,
        [pbr::OriginalName("PLAY_ROUGH")]
        PlayRough = 88,
        [pbr::OriginalName("CROSS_POISON")]
        CrossPoison = 89,
        [pbr::OriginalName("SLUDGE_BOMB")]
        SludgeBomb = 90,
        [pbr::OriginalName("SLUDGE_WAVE")]
        SludgeWave = 91,
        [pbr::OriginalName("GUNK_SHOT")]
        GunkShot = 92,
        [pbr::OriginalName("MUD_SHOT")]
        MudShot = 93,
        [pbr::OriginalName("BONE_CLUB")]
        BoneClub = 94,
        [pbr::OriginalName("BULLDOZE")]
        Bulldoze = 95,
        [pbr::OriginalName("MUD_BOMB")]
        MudBomb = 96,
        [pbr::OriginalName("FURY_CUTTER")]
        FuryCutter = 97,
        [pbr::OriginalName("BUG_BITE")]
        BugBite = 98,
        [pbr::OriginalName("SIGNAL_BEAM")]
        SignalBeam = 99,
        [pbr::OriginalName("X_SCISSOR")]
        XScissor = 100,
        [pbr::OriginalName("FLAME_CHARGE")]
        FlameCharge = 101,
        [pbr::OriginalName("FLAME_BURST")]
        FlameBurst = 102,
        [pbr::OriginalName("FIRE_BLAST")]
        FireBlast = 103,
        [pbr::OriginalName("BRINE")]
        Brine = 104,
        [pbr::OriginalName("WATER_PULSE")]
        WaterPulse = 105,
        [pbr::OriginalName("SCALD")]
        Scald = 106,
        [pbr::OriginalName("HYDRO_PUMP")]
        HydroPump = 107,
        [pbr::OriginalName("PSYCHIC")]
        Psychic = 108,
        [pbr::OriginalName("PSYSTRIKE")]
        Psystrike = 109,
        [pbr::OriginalName("ICE_SHARD")]
        IceShard = 110,
        [pbr::OriginalName("ICY_WIND")]
        IcyWind = 111,
        [pbr::OriginalName("FROST_BREATH")]
        FrostBreath = 112,
        [pbr::OriginalName("ABSORB")]
        Absorb = 113,
        [pbr::OriginalName("GIGA_DRAIN")]
        GigaDrain = 114,
        [pbr::OriginalName("FIRE_PUNCH")]
        FirePunch = 115,
        [pbr::OriginalName("SOLAR_BEAM")]
        SolarBeam = 116,
        [pbr::OriginalName("LEAF_BLADE")]
        LeafBlade = 117,
        [pbr::OriginalName("POWER_WHIP")]
        PowerWhip = 118,
        [pbr::OriginalName("SPLASH")]
        Splash = 119,
        [pbr::OriginalName("ACID")]
        Acid = 120,
        [pbr::OriginalName("AIR_CUTTER")]
        AirCutter = 121,
        [pbr::OriginalName("HURRICANE")]
        Hurricane = 122,
        [pbr::OriginalName("BRICK_BREAK")]
        BrickBreak = 123,
        [pbr::OriginalName("CUT")]
        Cut = 124,
        [pbr::OriginalName("SWIFT")]
        Swift = 125,
        [pbr::OriginalName("HORN_ATTACK")]
        HornAttack = 126,
        [pbr::OriginalName("STOMP")]
        Stomp = 127,
        [pbr::OriginalName("HEADBUTT")]
        Headbutt = 128,
        [pbr::OriginalName("HYPER_FANG")]
        HyperFang = 129,
        [pbr::OriginalName("SLAM")]
        Slam = 130,
        [pbr::OriginalName("BODY_SLAM")]
        BodySlam = 131,
        [pbr::OriginalName("REST")]
        Rest = 132,
        [pbr::OriginalName("STRUGGLE")]
        Struggle = 133,
        [pbr::OriginalName("SCALD_BLASTOISE")]
        ScaldBlastoise = 134,
        [pbr::OriginalName("HYDRO_PUMP_BLASTOISE")]
        HydroPumpBlastoise = 135,
        [pbr::OriginalName("WRAP_GREEN")]
        WrapGreen = 136,
        [pbr::OriginalName("WRAP_PINK")]
        WrapPink = 137,
        [pbr::OriginalName("FURY_CUTTER_FAST")]
        FuryCutterFast = 200,
        [pbr::OriginalName("BUG_BITE_FAST")]
        BugBiteFast = 201,
        [pbr::OriginalName("BITE_FAST")]
        BiteFast = 202,
        [pbr::OriginalName("SUCKER_PUNCH_FAST")]
        SuckerPunchFast = 203,
        [pbr::OriginalName("DRAGON_BREATH_FAST")]
        DragonBreathFast = 204,
        [pbr::OriginalName("THUNDER_SHOCK_FAST")]
        ThunderShockFast = 205,
        [pbr::OriginalName("SPARK_FAST")]
        SparkFast = 206,
        [pbr::OriginalName("LOW_KICK_FAST")]
        LowKickFast = 207,
        [pbr::OriginalName("KARATE_CHOP_FAST")]
        KarateChopFast = 208,
        [pbr::OriginalName("EMBER_FAST")]
        EmberFast = 209,
        [pbr::OriginalName("WING_ATTACK_FAST")]
        WingAttackFast = 210,
        [pbr::OriginalName("PECK_FAST")]
        PeckFast = 211,
        [pbr::OriginalName("LICK_FAST")]
        LickFast = 212,
        [pbr::OriginalName("SHADOW_CLAW_FAST")]
        ShadowClawFast = 213,
        [pbr::OriginalName("VINE_WHIP_FAST")]
        VineWhipFast = 214,
        [pbr::OriginalName("RAZOR_LEAF_FAST")]
        RazorLeafFast = 215,
        [pbr::OriginalName("MUD_SHOT_FAST")]
        MudShotFast = 216,
        [pbr::OriginalName("ICE_SHARD_FAST")]
        IceShardFast = 217,
        [pbr::OriginalName("FROST_BREATH_FAST")]
        FrostBreathFast = 218,
        [pbr::OriginalName("QUICK_ATTACK_FAST")]
        QuickAttackFast = 219,
        [pbr::OriginalName("SCRATCH_FAST")]
        ScratchFast = 220,
        [pbr::OriginalName("TACKLE_FAST")]
        TackleFast = 221,
        [pbr::OriginalName("POUND_FAST")]
        PoundFast = 222,
        [pbr::OriginalName("CUT_FAST")]
        CutFast = 223,
        [pbr::OriginalName("POISON_JAB_FAST")]
        PoisonJabFast = 224,
        [pbr::OriginalName("ACID_FAST")]
        AcidFast = 225,
        [pbr::OriginalName("PSYCHO_CUT_FAST")]
        PsychoCutFast = 226,
        [pbr::OriginalName("ROCK_THROW_FAST")]
        RockThrowFast = 227,
        [pbr::OriginalName("METAL_CLAW_FAST")]
        MetalClawFast = 228,
        [pbr::OriginalName("BULLET_PUNCH_FAST")]
        BulletPunchFast = 229,
        [pbr::OriginalName("WATER_GUN_FAST")]
        WaterGunFast = 230,
        [pbr::OriginalName("SPLASH_FAST")]
        SplashFast = 231,
        [pbr::OriginalName("WATER_GUN_FAST_BLASTOISE")]
        WaterGunFastBlastoise = 232,
        [pbr::OriginalName("MUD_SLAP_FAST")]
        MudSlapFast = 233,
        [pbr::OriginalName("ZEN_HEADBUTT_FAST")]
        ZenHeadbuttFast = 234,
        [pbr::OriginalName("CONFUSION_FAST")]
        ConfusionFast = 235,
        [pbr::OriginalName("POISON_STING_FAST")]
        PoisonStingFast = 236,
        [pbr::OriginalName("BUBBLE_FAST")]
        BubbleFast = 237,
        [pbr::OriginalName("FEINT_ATTACK_FAST")]
        FeintAttackFast = 238,
        [pbr::OriginalName("STEEL_WING_FAST")]
        SteelWingFast = 239,
        [pbr::OriginalName("FIRE_FANG_FAST")]
        FireFangFast = 240,
        [pbr::OriginalName("ROCK_SMASH_FAST")]
        RockSmashFast = 241,
    }

    public enum ItemId
    {
        [pbr::OriginalName("ITEM_UNKNOWN")]
        ItemUnknown = 0,
        [pbr::OriginalName("ITEM_POKE_BALL")]
        ItemPokeBall = 1,
        [pbr::OriginalName("ITEM_GREAT_BALL")]
        ItemGreatBall = 2,
        [pbr::OriginalName("ITEM_ULTRA_BALL")]
        ItemUltraBall = 3,
        [pbr::OriginalName("ITEM_MASTER_BALL")]
        ItemMasterBall = 4,
        [pbr::OriginalName("ITEM_POTION")]
        ItemPotion = 101,
        [pbr::OriginalName("ITEM_SUPER_POTION")]
        ItemSuperPotion = 102,
        [pbr::OriginalName("ITEM_HYPER_POTION")]
        ItemHyperPotion = 103,
        [pbr::OriginalName("ITEM_MAX_POTION")]
        ItemMaxPotion = 104,
        [pbr::OriginalName("ITEM_REVIVE")]
        ItemRevive = 201,
        [pbr::OriginalName("ITEM_MAX_REVIVE")]
        ItemMaxRevive = 202,
        [pbr::OriginalName("ITEM_LUCKY_EGG")]
        ItemLuckyEgg = 301,
        [pbr::OriginalName("ITEM_INCENSE_ORDINARY")]
        ItemIncenseOrdinary = 401,
        [pbr::OriginalName("ITEM_INCENSE_SPICY")]
        ItemIncenseSpicy = 402,
        [pbr::OriginalName("ITEM_INCENSE_COOL")]
        ItemIncenseCool = 403,
        [pbr::OriginalName("ITEM_INCENSE_FLORAL")]
        ItemIncenseFloral = 404,
        [pbr::OriginalName("ITEM_TROY_DISK")]
        ItemTroyDisk = 501,
        [pbr::OriginalName("ITEM_X_ATTACK")]
        ItemXAttack = 602,
        [pbr::OriginalName("ITEM_X_DEFENSE")]
        ItemXDefense = 603,
        [pbr::OriginalName("ITEM_X_MIRACLE")]
        ItemXMiracle = 604,
        [pbr::OriginalName("ITEM_RAZZ_BERRY")]
        ItemRazzBerry = 701,
        [pbr::OriginalName("ITEM_BLUK_BERRY")]
        ItemBlukBerry = 702,
        [pbr::OriginalName("ITEM_NANAB_BERRY")]
        ItemNanabBerry = 703,
        [pbr::OriginalName("ITEM_WEPAR_BERRY")]
        ItemWeparBerry = 704,
        [pbr::OriginalName("ITEM_PINAP_BERRY")]
        ItemPinapBerry = 705,
        [pbr::OriginalName("ITEM_SPECIAL_CAMERA")]
        ItemSpecialCamera = 801,
        [pbr::OriginalName("ITEM_INCUBATOR_BASIC_UNLIMITED")]
        ItemIncubatorBasicUnlimited = 901,
        [pbr::OriginalName("ITEM_INCUBATOR_BASIC")]
        ItemIncubatorBasic = 902,
        [pbr::OriginalName("ITEM_POKEMON_STORAGE_UPGRADE")]
        ItemPokemonStorageUpgrade = 1001,
        [pbr::OriginalName("ITEM_ITEM_STORAGE_UPGRADE")]
        ItemItemStorageUpgrade = 1002,
    }

    public enum InventoryUpgradeType
    {
        [pbr::OriginalName("UPGRADE_UNSET")]
        UpgradeUnset = 0,
        [pbr::OriginalName("INCREASE_ITEM_STORAGE")]
        IncreaseItemStorage = 1,
        [pbr::OriginalName("INCREASE_POKEMON_STORAGE")]
        IncreasePokemonStorage = 2,
    }

    public enum EggIncubatorType
    {
        [pbr::OriginalName("INCUBATOR_UNSET")]
        IncubatorUnset = 0,
        [pbr::OriginalName("INCUBATOR_DISTANCE")]
        IncubatorDistance = 1,
    }

    public enum PokemonFamilyId
    {
        [pbr::OriginalName("FAMILY_UNSET")]
        FamilyUnset = 0,
        [pbr::OriginalName("FAMILY_BULBASAUR")]
        FamilyBulbasaur = 1,
        [pbr::OriginalName("FAMILY_CHARMANDER")]
        FamilyCharmander = 4,
        [pbr::OriginalName("FAMILY_SQUIRTLE")]
        FamilySquirtle = 7,
        [pbr::OriginalName("FAMILY_CATERPIE")]
        FamilyCaterpie = 10,
        [pbr::OriginalName("FAMILY_WEEDLE")]
        FamilyWeedle = 13,
        [pbr::OriginalName("FAMILY_PIDGEY")]
        FamilyPidgey = 16,
        [pbr::OriginalName("FAMILY_RATTATA")]
        FamilyRattata = 19,
        [pbr::OriginalName("FAMILY_SPEAROW")]
        FamilySpearow = 21,
        [pbr::OriginalName("FAMILY_EKANS")]
        FamilyEkans = 23,
        [pbr::OriginalName("FAMILY_PIKACHU")]
        FamilyPikachu = 25,
        [pbr::OriginalName("FAMILY_SANDSHREW")]
        FamilySandshrew = 27,
        [pbr::OriginalName("FAMILY_NIDORAN")]
        FamilyNidoran = 29,
        [pbr::OriginalName("FAMILY_NIDORAN2")]
        FamilyNidoran2 = 32,
        [pbr::OriginalName("FAMILY_CLEFAIRY")]
        FamilyClefairy = 35,
        [pbr::OriginalName("FAMILY_VULPIX")]
        FamilyVulpix = 37,
        [pbr::OriginalName("FAMILY_JIGGLYPUFF")]
        FamilyJigglypuff = 39,
        [pbr::OriginalName("FAMILY_ZUBAT")]
        FamilyZubat = 41,
        [pbr::OriginalName("FAMILY_ODDISH")]
        FamilyOddish = 43,
        [pbr::OriginalName("FAMILY_PARAS")]
        FamilyParas = 46,
        [pbr::OriginalName("FAMILY_VENONAT")]
        FamilyVenonat = 48,
        [pbr::OriginalName("FAMILY_DIGLETT")]
        FamilyDiglett = 50,
        [pbr::OriginalName("FAMILY_MEOWTH")]
        FamilyMeowth = 52,
        [pbr::OriginalName("FAMILY_PSYDUCK")]
        FamilyPsyduck = 54,
        [pbr::OriginalName("FAMILY_MANKEY")]
        FamilyMankey = 56,
        [pbr::OriginalName("FAMILY_GROWLITHE")]
        FamilyGrowlithe = 58,
        [pbr::OriginalName("FAMILY_POLIWAG")]
        FamilyPoliwag = 60,
        [pbr::OriginalName("FAMILY_ABRA")]
        FamilyAbra = 63,
        [pbr::OriginalName("FAMILY_MACHOP")]
        FamilyMachop = 66,
        [pbr::OriginalName("FAMILY_BELLSPROUT")]
        FamilyBellsprout = 69,
        [pbr::OriginalName("FAMILY_TENTACOOL")]
        FamilyTentacool = 72,
        [pbr::OriginalName("FAMILY_GEODUDE")]
        FamilyGeodude = 74,
        [pbr::OriginalName("FAMILY_PONYTA")]
        FamilyPonyta = 77,
        [pbr::OriginalName("FAMILY_SLOWPOKE")]
        FamilySlowpoke = 79,
        [pbr::OriginalName("FAMILY_MAGNEMITE")]
        FamilyMagnemite = 81,
        [pbr::OriginalName("FAMILY_FARFETCHD")]
        FamilyFarfetchd = 83,
        [pbr::OriginalName("FAMILY_DODUO")]
        FamilyDoduo = 84,
        [pbr::OriginalName("FAMILY_SEEL")]
        FamilySeel = 86,
        [pbr::OriginalName("FAMILY_GRIMER")]
        FamilyGrimer = 88,
        [pbr::OriginalName("FAMILY_SHELLDER")]
        FamilyShellder = 90,
        [pbr::OriginalName("FAMILY_GASTLY")]
        FamilyGastly = 92,
        [pbr::OriginalName("FAMILY_ONIX")]
        FamilyOnix = 95,
        [pbr::OriginalName("FAMILY_DROWZEE")]
        FamilyDrowzee = 96,
        [pbr::OriginalName("FAMILY_KRABBY")]
        FamilyKrabby = 98,
        [pbr::OriginalName("FAMILY_VOLTORB")]
        FamilyVoltorb = 100,
        [pbr::OriginalName("FAMILY_EXEGGCUTE")]
        FamilyExeggcute = 102,
        [pbr::OriginalName("FAMILY_CUBONE")]
        FamilyCubone = 104,
        [pbr::OriginalName("FAMILY_HITMONLEE")]
        FamilyHitmonlee = 106,
        [pbr::OriginalName("FAMILY_HITMONCHAN")]
        FamilyHitmonchan = 107,
        [pbr::OriginalName("FAMILY_LICKITUNG")]
        FamilyLickitung = 108,
        [pbr::OriginalName("FAMILY_KOFFING")]
        FamilyKoffing = 109,
        [pbr::OriginalName("FAMILY_RHYHORN")]
        FamilyRhyhorn = 111,
        [pbr::OriginalName("FAMILY_CHANSEY")]
        FamilyChansey = 113,
        [pbr::OriginalName("FAMILY_TANGELA")]
        FamilyTangela = 114,
        [pbr::OriginalName("FAMILY_KANGASKHAN")]
        FamilyKangaskhan = 115,
        [pbr::OriginalName("FAMILY_HORSEA")]
        FamilyHorsea = 116,
        [pbr::OriginalName("FAMILY_GOLDEEN")]
        FamilyGoldeen = 118,
        [pbr::OriginalName("FAMILY_STARYU")]
        FamilyStaryu = 120,
        [pbr::OriginalName("FAMILY_MR_MIME")]
        FamilyMrMime = 122,
        [pbr::OriginalName("FAMILY_SCYTHER")]
        FamilyScyther = 123,
        [pbr::OriginalName("FAMILY_JYNX")]
        FamilyJynx = 124,
        [pbr::OriginalName("FAMILY_ELECTABUZZ")]
        FamilyElectabuzz = 125,
        [pbr::OriginalName("FAMILY_MAGMAR")]
        FamilyMagmar = 126,
        [pbr::OriginalName("FAMILY_PINSIR")]
        FamilyPinsir = 127,
        [pbr::OriginalName("FAMILY_TAUROS")]
        FamilyTauros = 128,
        [pbr::OriginalName("FAMILY_MAGIKARP")]
        FamilyMagikarp = 129,
        [pbr::OriginalName("FAMILY_LAPRAS")]
        FamilyLapras = 131,
        [pbr::OriginalName("FAMILY_DITTO")]
        FamilyDitto = 132,
        [pbr::OriginalName("FAMILY_EEVEE")]
        FamilyEevee = 133,
        [pbr::OriginalName("FAMILY_PORYGON")]
        FamilyPorygon = 137,
        [pbr::OriginalName("FAMILY_OMANYTE")]
        FamilyOmanyte = 138,
        [pbr::OriginalName("FAMILY_KABUTO")]
        FamilyKabuto = 140,
        [pbr::OriginalName("FAMILY_AERODACTYL")]
        FamilyAerodactyl = 142,
        [pbr::OriginalName("FAMILY_SNORLAX")]
        FamilySnorlax = 143,
        [pbr::OriginalName("FAMILY_ARTICUNO")]
        FamilyArticuno = 144,
        [pbr::OriginalName("FAMILY_ZAPDOS")]
        FamilyZapdos = 145,
        [pbr::OriginalName("FAMILY_MOLTRES")]
        FamilyMoltres = 146,
        [pbr::OriginalName("FAMILY_DRATINI")]
        FamilyDratini = 147,
        [pbr::OriginalName("FAMILY_MEWTWO")]
        FamilyMewtwo = 150,
        [pbr::OriginalName("FAMILY_MEW")]
        FamilyMew = 151,
    }

    public enum MapObjectsStatus
    {
        [pbr::OriginalName("UNSET_STATUS")]
        UnsetStatus = 0,
        [pbr::OriginalName("SUCCESS")]
        Success = 1,
        [pbr::OriginalName("LOCATION_UNSET")]
        LocationUnset = 2,
    }

    public enum FortType
    {
        [pbr::OriginalName("GYM")]
        Gym = 0,
        [pbr::OriginalName("CHECKPOINT")]
        Checkpoint = 1,
    }

    public enum PokemonId
    {
        [pbr::OriginalName("MISSINGNO")]
        Missingno = 0,
        [pbr::OriginalName("BULBASAUR")]
        Bulbasaur = 1,
        [pbr::OriginalName("IVYSAUR")]
        Ivysaur = 2,
        [pbr::OriginalName("VENUSAUR")]
        Venusaur = 3,
        [pbr::OriginalName("CHARMANDER")]
        Charmander = 4,
        [pbr::OriginalName("CHARMELEON")]
        Charmeleon = 5,
        [pbr::OriginalName("CHARIZARD")]
        Charizard = 6,
        [pbr::OriginalName("SQUIRTLE")]
        Squirtle = 7,
        [pbr::OriginalName("WARTORTLE")]
        Wartortle = 8,
        [pbr::OriginalName("BLASTOISE")]
        Blastoise = 9,
        [pbr::OriginalName("CATERPIE")]
        Caterpie = 10,
        [pbr::OriginalName("METAPOD")]
        Metapod = 11,
        [pbr::OriginalName("BUTTERFREE")]
        Butterfree = 12,
        [pbr::OriginalName("WEEDLE")]
        Weedle = 13,
        [pbr::OriginalName("KAKUNA")]
        Kakuna = 14,
        [pbr::OriginalName("BEEDRILL")]
        Beedrill = 15,
        [pbr::OriginalName("PIDGEY")]
        Pidgey = 16,
        [pbr::OriginalName("PIDGEOTTO")]
        Pidgeotto = 17,
        [pbr::OriginalName("PIDGEOT")]
        Pidgeot = 18,
        [pbr::OriginalName("RATTATA")]
        Rattata = 19,
        [pbr::OriginalName("RATICATE")]
        Raticate = 20,
        [pbr::OriginalName("SPEAROW")]
        Spearow = 21,
        [pbr::OriginalName("FEAROW")]
        Fearow = 22,
        [pbr::OriginalName("EKANS")]
        Ekans = 23,
        [pbr::OriginalName("ARBOK")]
        Arbok = 24,
        [pbr::OriginalName("PIKACHU")]
        Pikachu = 25,
        [pbr::OriginalName("RAICHU")]
        Raichu = 26,
        [pbr::OriginalName("SANDSHREW")]
        Sandshrew = 27,
        [pbr::OriginalName("SANDLASH")]
        Sandlash = 28,
        [pbr::OriginalName("NIDORAN_FEMALE")]
        NidoranFemale = 29,
        [pbr::OriginalName("NIDORINA")]
        Nidorina = 30,
        [pbr::OriginalName("NIDOQUEEN")]
        Nidoqueen = 31,
        [pbr::OriginalName("NIDORAN_MALE")]
        NidoranMale = 32,
        [pbr::OriginalName("NIDORINO")]
        Nidorino = 33,
        [pbr::OriginalName("NIDOKING")]
        Nidoking = 34,
        [pbr::OriginalName("CLEFAIRY")]
        Clefairy = 35,
        [pbr::OriginalName("CLEFABLE")]
        Clefable = 36,
        [pbr::OriginalName("VULPIX")]
        Vulpix = 37,
        [pbr::OriginalName("NINETALES")]
        Ninetales = 38,
        [pbr::OriginalName("JIGGLYPUFF")]
        Jigglypuff = 39,
        [pbr::OriginalName("WIGGLYTUFF")]
        Wigglytuff = 40,
        [pbr::OriginalName("ZUBAT")]
        Zubat = 41,
        [pbr::OriginalName("GOLBAT")]
        Golbat = 42,
        [pbr::OriginalName("ODDISH")]
        Oddish = 43,
        [pbr::OriginalName("GLOOM")]
        Gloom = 44,
        [pbr::OriginalName("VILEPLUME")]
        Vileplume = 45,
        [pbr::OriginalName("PARAS")]
        Paras = 46,
        [pbr::OriginalName("PARASECT")]
        Parasect = 47,
        [pbr::OriginalName("VENONAT")]
        Venonat = 48,
        [pbr::OriginalName("VENOMOTH")]
        Venomoth = 49,
        [pbr::OriginalName("DIGLETT")]
        Diglett = 50,
        [pbr::OriginalName("DUGTRIO")]
        Dugtrio = 51,
        [pbr::OriginalName("MEOWTH")]
        Meowth = 52,
        [pbr::OriginalName("PERSIAN")]
        Persian = 53,
        [pbr::OriginalName("PSYDUCK")]
        Psyduck = 54,
        [pbr::OriginalName("GOLDUCK")]
        Golduck = 55,
        [pbr::OriginalName("MANKEY")]
        Mankey = 56,
        [pbr::OriginalName("PRIMEAPE")]
        Primeape = 57,
        [pbr::OriginalName("GROWLITHE")]
        Growlithe = 58,
        [pbr::OriginalName("ARCANINE")]
        Arcanine = 59,
        [pbr::OriginalName("POLIWAG")]
        Poliwag = 60,
        [pbr::OriginalName("POLIWHIRL")]
        Poliwhirl = 61,
        [pbr::OriginalName("POLIWRATH")]
        Poliwrath = 62,
        [pbr::OriginalName("ABRA")]
        Abra = 63,
        [pbr::OriginalName("KADABRA")]
        Kadabra = 64,
        [pbr::OriginalName("ALAKHAZAM")]
        Alakhazam = 65,
        [pbr::OriginalName("MACHOP")]
        Machop = 66,
        [pbr::OriginalName("MACHOKE")]
        Machoke = 67,
        [pbr::OriginalName("MACHAMP")]
        Machamp = 68,
        [pbr::OriginalName("BELLSPROUT")]
        Bellsprout = 69,
        [pbr::OriginalName("WEEPINBELL")]
        Weepinbell = 70,
        [pbr::OriginalName("VICTREEBELL")]
        Victreebell = 71,
        [pbr::OriginalName("TENTACOOL")]
        Tentacool = 72,
        [pbr::OriginalName("TENTACRUEL")]
        Tentacruel = 73,
        [pbr::OriginalName("GEODUDE")]
        Geodude = 74,
        [pbr::OriginalName("GRAVELER")]
        Graveler = 75,
        [pbr::OriginalName("GOLEM")]
        Golem = 76,
        [pbr::OriginalName("PONYTA")]
        Ponyta = 77,
        [pbr::OriginalName("RAPIDASH")]
        Rapidash = 78,
        [pbr::OriginalName("SLOWPOKE")]
        Slowpoke = 79,
        [pbr::OriginalName("SLOWBRO")]
        Slowbro = 80,
        [pbr::OriginalName("MAGNEMITE")]
        Magnemite = 81,
        [pbr::OriginalName("MAGNETON")]
        Magneton = 82,
        [pbr::OriginalName("FARFETCHD")]
        Farfetchd = 83,
        [pbr::OriginalName("DODUO")]
        Doduo = 84,
        [pbr::OriginalName("DODRIO")]
        Dodrio = 85,
        [pbr::OriginalName("SEEL")]
        Seel = 86,
        [pbr::OriginalName("DEWGONG")]
        Dewgong = 87,
        [pbr::OriginalName("GRIMER")]
        Grimer = 88,
        [pbr::OriginalName("MUK")]
        Muk = 89,
        [pbr::OriginalName("SHELLDER")]
        Shellder = 90,
        [pbr::OriginalName("CLOYSTER")]
        Cloyster = 91,
        [pbr::OriginalName("GASTLY")]
        Gastly = 92,
        [pbr::OriginalName("HAUNTER")]
        Haunter = 93,
        [pbr::OriginalName("GENGAR")]
        Gengar = 94,
        [pbr::OriginalName("ONIX")]
        Onix = 95,
        [pbr::OriginalName("DROWZEE")]
        Drowzee = 96,
        [pbr::OriginalName("HYPNO")]
        Hypno = 97,
        [pbr::OriginalName("KRABBY")]
        Krabby = 98,
        [pbr::OriginalName("KINGLER")]
        Kingler = 99,
        [pbr::OriginalName("VOLTORB")]
        Voltorb = 100,
        [pbr::OriginalName("ELECTRODE")]
        Electrode = 101,
        [pbr::OriginalName("EXEGGCUTE")]
        Exeggcute = 102,
        [pbr::OriginalName("EXEGGUTOR")]
        Exeggutor = 103,
        [pbr::OriginalName("CUBONE")]
        Cubone = 104,
        [pbr::OriginalName("MAROWAK")]
        Marowak = 105,
        [pbr::OriginalName("HITMONLEE")]
        Hitmonlee = 106,
        [pbr::OriginalName("HITMONCHAN")]
        Hitmonchan = 107,
        [pbr::OriginalName("LICKITUNG")]
        Lickitung = 108,
        [pbr::OriginalName("KOFFING")]
        Koffing = 109,
        [pbr::OriginalName("WEEZING")]
        Weezing = 110,
        [pbr::OriginalName("RHYHORN")]
        Rhyhorn = 111,
        [pbr::OriginalName("RHYDON")]
        Rhydon = 112,
        [pbr::OriginalName("CHANSEY")]
        Chansey = 113,
        [pbr::OriginalName("TANGELA")]
        Tangela = 114,
        [pbr::OriginalName("KANGASKHAN")]
        Kangaskhan = 115,
        [pbr::OriginalName("HORSEA")]
        Horsea = 116,
        [pbr::OriginalName("SEADRA")]
        Seadra = 117,
        [pbr::OriginalName("GOLDEEN")]
        Goldeen = 118,
        [pbr::OriginalName("SEAKING")]
        Seaking = 119,
        [pbr::OriginalName("STARYU")]
        Staryu = 120,
        [pbr::OriginalName("STARMIE")]
        Starmie = 121,
        [pbr::OriginalName("MR_MIME")]
        MrMime = 122,
        [pbr::OriginalName("SCYTHER")]
        Scyther = 123,
        [pbr::OriginalName("JYNX")]
        Jynx = 124,
        [pbr::OriginalName("ELECTABUZZ")]
        Electabuzz = 125,
        [pbr::OriginalName("MAGMAR")]
        Magmar = 126,
        [pbr::OriginalName("PINSIR")]
        Pinsir = 127,
        [pbr::OriginalName("TAUROS")]
        Tauros = 128,
        [pbr::OriginalName("MAGIKARP")]
        Magikarp = 129,
        [pbr::OriginalName("GYARADOS")]
        Gyarados = 130,
        [pbr::OriginalName("LAPRAS")]
        Lapras = 131,
        [pbr::OriginalName("DITTO")]
        Ditto = 132,
        [pbr::OriginalName("EEVEE")]
        Eevee = 133,
        [pbr::OriginalName("VAPOREON")]
        Vaporeon = 134,
        [pbr::OriginalName("JOLTEON")]
        Jolteon = 135,
        [pbr::OriginalName("FLAREON")]
        Flareon = 136,
        [pbr::OriginalName("PORYGON")]
        Porygon = 137,
        [pbr::OriginalName("OMANYTE")]
        Omanyte = 138,
        [pbr::OriginalName("OMASTAR")]
        Omastar = 139,
        [pbr::OriginalName("KABUTO")]
        Kabuto = 140,
        [pbr::OriginalName("KABUTOPS")]
        Kabutops = 141,
        [pbr::OriginalName("AERODACTYL")]
        Aerodactyl = 142,
        [pbr::OriginalName("SNORLAX")]
        Snorlax = 143,
        [pbr::OriginalName("ARTICUNO")]
        Articuno = 144,
        [pbr::OriginalName("ZAPDOS")]
        Zapdos = 145,
        [pbr::OriginalName("MOLTRES")]
        Moltres = 146,
        [pbr::OriginalName("DRATINI")]
        Dratini = 147,
        [pbr::OriginalName("DRAGONAIR")]
        Dragonair = 148,
        [pbr::OriginalName("DRAGONITE")]
        Dragonite = 149,
        [pbr::OriginalName("MEWTWO")]
        Mewtwo = 150,
        [pbr::OriginalName("MEW")]
        Mew = 151,
    }

    public enum FortSponsor
    {
        [pbr::OriginalName("UNSET_SPONSOR")]
        UnsetSponsor = 0,
        [pbr::OriginalName("MCDONALDS")]
        Mcdonalds = 1,
        [pbr::OriginalName("POKEMON_STORE")]
        PokemonStore = 2,
    }

    public enum FortRenderingType
    {
        [pbr::OriginalName("DEFAULT")]
        Default = 0,
        [pbr::OriginalName("INTERNAL_TEST")]
        InternalTest = 1,
    }

    public enum ItemType
    {
        [pbr::OriginalName("ITEM_TYPE_NONE")]
        None = 0,
        [pbr::OriginalName("ITEM_TYPE_POKEBALL")]
        Pokeball = 1,
        [pbr::OriginalName("ITEM_TYPE_GREAT_BALL")]
        GreatBall = 2,
        [pbr::OriginalName("ITEM_TYPE_ULTRA_BALL")]
        UltraBall = 3,
        [pbr::OriginalName("ITEM_TYPE_POTION")]
        Potion = 101,
        [pbr::OriginalName("ITEM_TYPE_SUPER_POTION")]
        SuperPotion = 102,
        [pbr::OriginalName("ITEM_RAZZ_BERRY")]
        RazzBerry = 701,
        [pbr::OriginalName("ITEM_TYPE_REVIVE")]
        Revive = 201,
        [pbr::OriginalName("ITEM_TYPE_MAP")]
        Map = 4,
        [pbr::OriginalName("ITEM_TYPE_BATTLE")]
        Battle = 5,
        [pbr::OriginalName("ITEM_TYPE_FOOD")]
        Food = 6,
        [pbr::OriginalName("ITEM_TYPE_CAMERA")]
        Camera = 7,
        [pbr::OriginalName("ITEM_TYPE_DISK")]
        Disk = 8,
        [pbr::OriginalName("ITEM_TYPE_INCUBATOR")]
        Incubator = 9,
        [pbr::OriginalName("ITEM_TYPE_INCENSE")]
        Incense = 10,
        [pbr::OriginalName("ITEM_TYPE_XP_BOOST")]
        XpBoost = 11,
        [pbr::OriginalName("ITEM_TYPE_INVENTORY_UPGRADE")]
        InventoryUpgrade = 12,
    }

    public enum ItemCategory
    {
        [pbr::OriginalName("ITEM_CATEGORY_NONE")]
        None = 0,
        [pbr::OriginalName("ITEM_CATEGORY_POKEBALL")]
        Pokeball = 1,
        [pbr::OriginalName("ITEM_CATEGORY_FOOD")]
        Food = 2,
        [pbr::OriginalName("ITEM_CATEGORY_MEDICINE")]
        Medicine = 3,
        [pbr::OriginalName("ITEM_CATEGORY_BOOST")]
        Boost = 4,
        [pbr::OriginalName("ITEM_CATEGORY_UTILITES")]
        Utilites = 5,
        [pbr::OriginalName("ITEM_CATEGORY_CAMERA")]
        Camera = 6,
        [pbr::OriginalName("ITEM_CATEGORY_DISK")]
        Disk = 7,
        [pbr::OriginalName("ITEM_CATEGORY_INCUBATOR")]
        Incubator = 8,
        [pbr::OriginalName("ITEM_CATEGORY_INCENSE")]
        Incense = 9,
        [pbr::OriginalName("ITEM_CATEGORY_XP_BOOST")]
        XpBoost = 10,
        [pbr::OriginalName("ITEM_CATEGORY_INVENTORY_UPGRADE")]
        InventoryUpgrade = 11,
    }

    public enum ItemEffect
    {
        [pbr::OriginalName("ITEM_EFFECT_NONE")]
        None = 0,
        [pbr::OriginalName("ITEM_EFFECT_CAP_NO_FLEE")]
        CapNoFlee = 1000,
        [pbr::OriginalName("ITEM_EFFECT_CAP_NO_MOVEMENT")]
        CapNoMovement = 1002,
        [pbr::OriginalName("ITEM_EFFECT_CAP_NO_THREAT")]
        CapNoThreat = 1003,
        [pbr::OriginalName("ITEM_EFFECT_CAP_TARGET_MAX")]
        CapTargetMax = 1004,
        [pbr::OriginalName("ITEM_EFFECT_CAP_TARGET_SLOW")]
        CapTargetSlow = 1005,
        [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_NIGHT")]
        CapChanceNight = 1006,
        [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_TRAINER")]
        CapChanceTrainer = 1007,
        [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_FIRST_THROW")]
        CapChanceFirstThrow = 1008,
        [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_LEGEND")]
        CapChanceLegend = 1009,
        [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_HEAVY")]
        CapChanceHeavy = 1010,
        [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_REPEAT")]
        CapChanceRepeat = 1011,
        [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_MULTI_THROW")]
        CapChanceMultiThrow = 1012,
        [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_ALWAYS")]
        CapChanceAlways = 1013,
        [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_SINGLE_THROW")]
        CapChanceSingleThrow = 1014,
    }

    public enum ActivityType
    {
        [pbr::OriginalName("ACTIVITY_UNKNOWN")]
        ActivityUnknown = 0,
        [pbr::OriginalName("ACTIVITY_CATCH_POKEMON")]
        ActivityCatchPokemon = 1,
        [pbr::OriginalName("ACTIVITY_CATCH_LEGEND_POKEMON")]
        ActivityCatchLegendPokemon = 2,
        [pbr::OriginalName("ACTIVITY_FLEE_POKEMON")]
        ActivityFleePokemon = 3,
        [pbr::OriginalName("ACTIVITY_DEFEAT_FORT")]
        ActivityDefeatFort = 4,
        [pbr::OriginalName("ACTIVITY_EVOLVE_POKEMON")]
        ActivityEvolvePokemon = 5,
        [pbr::OriginalName("ACTIVITY_HATCH_EGG")]
        ActivityHatchEgg = 6,
        [pbr::OriginalName("ACTIVITY_WALK_KM")]
        ActivityWalkKm = 7,
        [pbr::OriginalName("ACTIVITY_POKEDEX_ENTRY_NEW")]
        ActivityPokedexEntryNew = 8,
        [pbr::OriginalName("ACTIVITY_CATCH_FIRST_THROW")]
        ActivityCatchFirstThrow = 9,
        [pbr::OriginalName("ACTIVITY_CATCH_NICE_THROW")]
        ActivityCatchNiceThrow = 10,
        [pbr::OriginalName("ACTIVITY_CATCH_GREAT_THROW")]
        ActivityCatchGreatThrow = 11,
        [pbr::OriginalName("ACTIVITY_CATCH_EXCELLENT_THROW")]
        ActivityCatchExcellentThrow = 12,
        [pbr::OriginalName("ACTIVITY_CATCH_CURVEBALL")]
        ActivityCatchCurveball = 13,
        [pbr::OriginalName("ACTIVITY_CATCH_FIRST_CATCH_OF_DAY")]
        ActivityCatchFirstCatchOfDay = 14,
        [pbr::OriginalName("ACTIVITY_CATCH_MILESTONE")]
        ActivityCatchMilestone = 15,
        [pbr::OriginalName("ACTIVITY_TRAIN_POKEMON")]
        ActivityTrainPokemon = 16,
        [pbr::OriginalName("ACTIVITY_SEARCH_FORT")]
        ActivitySearchFort = 17,
        [pbr::OriginalName("ACTIVITY_RELEASE_POKEMON")]
        ActivityReleasePokemon = 18,
        [pbr::OriginalName("ACTIVITY_HATCH_EGG_SMALL_BONUS")]
        ActivityHatchEggSmallBonus = 19,
        [pbr::OriginalName("ACTIVITY_HATCH_EGG_MEDIUM_BONUS")]
        ActivityHatchEggMediumBonus = 20,
        [pbr::OriginalName("ACTIVITY_HATCH_EGG_LARGE_BONUS")]
        ActivityHatchEggLargeBonus = 21,
        [pbr::OriginalName("ACTIVITY_DEFEAT_GYM_DEFENDER")]
        ActivityDefeatGymDefender = 22,
        [pbr::OriginalName("ACTIVITY_DEFEAT_GYM_LEADER")]
        ActivityDefeatGymLeader = 23,
    }

    public enum BadgeType
    {
        [pbr::OriginalName("BADGE_UNSET")]
        BadgeUnset = 0,
        [pbr::OriginalName("BADGE_TRAVEL_KM")]
        BadgeTravelKm = 1,
        [pbr::OriginalName("BADGE_POKEDEX_ENTRIES")]
        BadgePokedexEntries = 2,
        [pbr::OriginalName("BADGE_CAPTURE_TOTAL")]
        BadgeCaptureTotal = 3,
        [pbr::OriginalName("BADGE_DEFEATED_FORT")]
        BadgeDefeatedFort = 4,
        [pbr::OriginalName("BADGE_EVOLVED_TOTAL")]
        BadgeEvolvedTotal = 5,
        [pbr::OriginalName("BADGE_HATCHED_TOTAL")]
        BadgeHatchedTotal = 6,
        [pbr::OriginalName("BADGE_ENCOUNTERED_TOTAL")]
        BadgeEncounteredTotal = 7,
        [pbr::OriginalName("BADGE_POKESTOPS_VISITED")]
        BadgePokestopsVisited = 8,
        [pbr::OriginalName("BADGE_UNIQUE_POKESTOPS")]
        BadgeUniquePokestops = 9,
        [pbr::OriginalName("BADGE_POKEBALL_THROWN")]
        BadgePokeballThrown = 10,
        [pbr::OriginalName("BADGE_BIG_MAGIKARP")]
        BadgeBigMagikarp = 11,
        [pbr::OriginalName("BADGE_DEPLOYED_TOTAL")]
        BadgeDeployedTotal = 12,
        [pbr::OriginalName("BADGE_BATTLE_ATTACK_WON")]
        BadgeBattleAttackWon = 13,
        [pbr::OriginalName("BADGE_BATTLE_TRAINING_WON")]
        BadgeBattleTrainingWon = 14,
        [pbr::OriginalName("BADGE_BATTLE_DEFEND_WON")]
        BadgeBattleDefendWon = 15,
        [pbr::OriginalName("BADGE_PRESTIGE_RAISED")]
        BadgePrestigeRaised = 16,
        [pbr::OriginalName("BADGE_PRESTIGE_DROPPED")]
        BadgePrestigeDropped = 17,
        [pbr::OriginalName("BADGE_TYPE_NORMAL")]
        Normal = 18,
        [pbr::OriginalName("BADGE_TYPE_FIGHTING")]
        Fighting = 19,
        [pbr::OriginalName("BADGE_TYPE_FLYING")]
        Flying = 20,
        [pbr::OriginalName("BADGE_TYPE_POISON")]
        Poison = 21,
        [pbr::OriginalName("BADGE_TYPE_GROUND")]
        Ground = 22,
        [pbr::OriginalName("BADGE_TYPE_ROCK")]
        Rock = 23,
        [pbr::OriginalName("BADGE_TYPE_BUG")]
        Bug = 24,
        [pbr::OriginalName("BADGE_TYPE_GHOST")]
        Ghost = 25,
        [pbr::OriginalName("BADGE_TYPE_STEEL")]
        Steel = 26,
        [pbr::OriginalName("BADGE_TYPE_FIRE")]
        Fire = 27,
        [pbr::OriginalName("BADGE_TYPE_WATER")]
        Water = 28,
        [pbr::OriginalName("BADGE_TYPE_GRASS")]
        Grass = 29,
        [pbr::OriginalName("BADGE_TYPE_ELECTRIC")]
        Electric = 30,
        [pbr::OriginalName("BADGE_TYPE_PSYCHIC")]
        Psychic = 31,
        [pbr::OriginalName("BADGE_TYPE_ICE")]
        Ice = 32,
        [pbr::OriginalName("BADGE_TYPE_DRAGON")]
        Dragon = 33,
        [pbr::OriginalName("BADGE_TYPE_DARK")]
        Dark = 34,
        [pbr::OriginalName("BADGE_TYPE_FAIRY")]
        Fairy = 35,
        [pbr::OriginalName("BADGE_SMALL_RATTATA")]
        BadgeSmallRattata = 36,
        [pbr::OriginalName("BADGE_PIKACHU")]
        BadgePikachu = 37,
    }

    public enum HoloIapItemCategory
    {
        [pbr::OriginalName("IAP_CATEGORY_NONE")]
        IapCategoryNone = 0,
        [pbr::OriginalName("IAP_CATEGORY_BUNDLE")]
        IapCategoryBundle = 1,
        [pbr::OriginalName("IAP_CATEGORY_ITEMS")]
        IapCategoryItems = 2,
        [pbr::OriginalName("IAP_CATEGORY_UPGRADES")]
        IapCategoryUpgrades = 3,
        [pbr::OriginalName("IAP_CATEGORY_POKECOINS")]
        IapCategoryPokecoins = 4,
    }

    public enum CameraInterpolation
    {
        [pbr::OriginalName("CAM_INTERP_CUT")]
        CamInterpCut = 0,
        [pbr::OriginalName("CAM_INTERP_LINEAR")]
        CamInterpLinear = 1,
        [pbr::OriginalName("CAM_INTERP_SMOOTH")]
        CamInterpSmooth = 2,
        [pbr::OriginalName("CAM_INTERP_SMOOTH_ROT_LINEAR_MOVE")]
        CamInterpSmoothRotLinearMove = 3,
        [pbr::OriginalName("CAM_INTERP_DEPENDS")]
        CamInterpDepends = 4,
    }

    public enum CameraTarget
    {
        [pbr::OriginalName("CAM_TARGET_ATTACKER")]
        CamTargetAttacker = 0,
        [pbr::OriginalName("CAM_TARGET_ATTACKER_EDGE")]
        CamTargetAttackerEdge = 1,
        [pbr::OriginalName("CAM_TARGET_ATTACKER_GROUND")]
        CamTargetAttackerGround = 2,
        [pbr::OriginalName("CAM_TARGET_DEFENDER")]
        CamTargetDefender = 3,
        [pbr::OriginalName("CAM_TARGET_DEFENDER_EDGE")]
        CamTargetDefenderEdge = 4,
        [pbr::OriginalName("CAM_TARGET_DEFENDER_GROUND")]
        CamTargetDefenderGround = 5,
        [pbr::OriginalName("CAM_TARGET_ATTACKER_DEFENDER")]
        CamTargetAttackerDefender = 6,
        [pbr::OriginalName("CAM_TARGET_ATTACKER_DEFENDER_EDGE")]
        CamTargetAttackerDefenderEdge = 7,
        [pbr::OriginalName("CAM_TARGET_DEFENDER_ATTACKER")]
        CamTargetDefenderAttacker = 8,
        [pbr::OriginalName("CAM_TARGET_DEFENDER_ATTACKER_EDGE")]
        CamTargetDefenderAttackerEdge = 9,
        [pbr::OriginalName("CAM_TARGET_ATTACKER_DEFENDER_MIRROR")]
        CamTargetAttackerDefenderMirror = 11,
        [pbr::OriginalName("CAM_TARGET_SHOULDER_ATTACKER_DEFENDER")]
        CamTargetShoulderAttackerDefender = 12,
        [pbr::OriginalName("CAM_TARGET_SHOULDER_ATTACKER_DEFENDER_MIRROR")]
        CamTargetShoulderAttackerDefenderMirror = 13,
        [pbr::OriginalName("CAM_TARGET_ATTACKER_DEFENDER_WORLD")]
        CamTargetAttackerDefenderWorld = 14,
    }

    public enum PokemonType
    {
        [pbr::OriginalName("POKEMON_TYPE_NONE")]
        None = 0,
        [pbr::OriginalName("POKEMON_TYPE_NORMAL")]
        Normal = 1,
        [pbr::OriginalName("POKEMON_TYPE_FIGHTING")]
        Fighting = 2,
        [pbr::OriginalName("POKEMON_TYPE_FLYING")]
        Flying = 3,
        [pbr::OriginalName("POKEMON_TYPE_POISON")]
        Poison = 4,
        [pbr::OriginalName("POKEMON_TYPE_GROUND")]
        Ground = 5,
        [pbr::OriginalName("POKEMON_TYPE_ROCK")]
        Rock = 6,
        [pbr::OriginalName("POKEMON_TYPE_BUG")]
        Bug = 7,
        [pbr::OriginalName("POKEMON_TYPE_GHOST")]
        Ghost = 8,
        [pbr::OriginalName("POKEMON_TYPE_STEEL")]
        Steel = 9,
        [pbr::OriginalName("POKEMON_TYPE_FIRE")]
        Fire = 10,
        [pbr::OriginalName("POKEMON_TYPE_WATER")]
        Water = 11,
        [pbr::OriginalName("POKEMON_TYPE_GRASS")]
        Grass = 12,
        [pbr::OriginalName("POKEMON_TYPE_ELECTRIC")]
        Electric = 13,
        [pbr::OriginalName("POKEMON_TYPE_PSYCHIC")]
        Psychic = 14,
        [pbr::OriginalName("POKEMON_TYPE_ICE")]
        Ice = 15,
        [pbr::OriginalName("POKEMON_TYPE_DRAGON")]
        Dragon = 16,
        [pbr::OriginalName("POKEMON_TYPE_DARK")]
        Dark = 17,
        [pbr::OriginalName("POKEMON_TYPE_FAIRY")]
        Fairy = 18,
    }

    public enum PokemonMovementType
    {
        [pbr::OriginalName("MOVEMENT_STATIC")]
        MovementStatic = 0,
        [pbr::OriginalName("MOVEMENT_JUMP")]
        MovementJump = 1,
        [pbr::OriginalName("MOVEMENT_VERTICAL")]
        MovementVertical = 2,
        [pbr::OriginalName("MOVEMENT_PSYCHIC")]
        MovementPsychic = 3,
        [pbr::OriginalName("MOVEMENT_ELECTRIC")]
        MovementElectric = 4,
        [pbr::OriginalName("MOVEMENT_FLYING")]
        MovementFlying = 5,
        [pbr::OriginalName("MOVEMENT_HOVERING")]
        MovementHovering = 6,
    }

    public enum PokemonClass
    {
        [pbr::OriginalName("NORMAL")]
        Normal = 0,
        [pbr::OriginalName("LEGENDARY")]
        Legendary = 1,
        [pbr::OriginalName("MYTHIC")]
        Mythic = 2,
    }

    #endregion
}

#endregion Designer generated code