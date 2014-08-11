/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace forseti2
{
    public sealed class piemos_override : LCM.LCM.LCMEncodable
    {
        public forseti2.header header;
        public int team;
        public bool override;
 
        public piemos_override()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x05ced4af13b32459L;
 
        static piemos_override()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("forseti2.piemos_override"))
                return 0L;
 
            classes.Add("forseti2.piemos_override");
            ulong hash = LCM_FINGERPRINT_BASE
                 + forseti2.header._hashRecursive(classes)
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(LCMDataOutputStream outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(LCMDataOutputStream outs)
        {
            this.header._encodeRecursive(outs); 
 
            outs.Write(this.team); 
 
            outs.Write(this.override); 
 
        }
 
        public piemos_override(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public piemos_override(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static forseti2.piemos_override _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            forseti2.piemos_override o = new forseti2.piemos_override();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.header = forseti2.header._decodeRecursiveFactory(ins);
 
            this.team = ins.ReadInt32();
 
            this.override = ins.ReadBoolean();
 
        }
 
        public forseti2.piemos_override Copy()
        {
            forseti2.piemos_override outobj = new forseti2.piemos_override();
            outobj.header = this.header.Copy();
 
            outobj.team = this.team;
 
            outobj.override = this.override;
 
            return outobj;
        }
    }
}

