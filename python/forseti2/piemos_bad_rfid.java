/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

package forseti2;
 
import java.io.*;
import java.util.*;
import lcm.lcm.*;
 
public final class piemos_bad_rfid implements lcm.lcm.LCMEncodable
{
    public forseti2.header header;
    public int station;
 
    public piemos_bad_rfid()
    {
    }
 
    public static final long LCM_FINGERPRINT;
    public static final long LCM_FINGERPRINT_BASE = 0x0e1342d8653fd742L;
 
    static {
        LCM_FINGERPRINT = _hashRecursive(new ArrayList<Class<?>>());
    }
 
    public static long _hashRecursive(ArrayList<Class<?>> classes)
    {
        if (classes.contains(forseti2.piemos_bad_rfid.class))
            return 0L;
 
        classes.add(forseti2.piemos_bad_rfid.class);
        long hash = LCM_FINGERPRINT_BASE
             + forseti2.header._hashRecursive(classes)
            ;
        classes.remove(classes.size() - 1);
        return (hash<<1) + ((hash>>63)&1);
    }
 
    public void encode(DataOutput outs) throws IOException
    {
        outs.writeLong(LCM_FINGERPRINT);
        _encodeRecursive(outs);
    }
 
    public void _encodeRecursive(DataOutput outs) throws IOException
    {
        this.header._encodeRecursive(outs); 
 
        outs.writeInt(this.station); 
 
    }
 
    public piemos_bad_rfid(byte[] data) throws IOException
    {
        this(new LCMDataInputStream(data));
    }
 
    public piemos_bad_rfid(DataInput ins) throws IOException
    {
        if (ins.readLong() != LCM_FINGERPRINT)
            throw new IOException("LCM Decode error: bad fingerprint");
 
        _decodeRecursive(ins);
    }
 
    public static forseti2.piemos_bad_rfid _decodeRecursiveFactory(DataInput ins) throws IOException
    {
        forseti2.piemos_bad_rfid o = new forseti2.piemos_bad_rfid();
        o._decodeRecursive(ins);
        return o;
    }
 
    public void _decodeRecursive(DataInput ins) throws IOException
    {
        this.header = forseti2.header._decodeRecursiveFactory(ins);
 
        this.station = ins.readInt();
 
    }
 
    public forseti2.piemos_bad_rfid copy()
    {
        forseti2.piemos_bad_rfid outobj = new forseti2.piemos_bad_rfid();
        outobj.header = this.header.copy();
 
        outobj.station = this.station;
 
        return outobj;
    }
 
}

