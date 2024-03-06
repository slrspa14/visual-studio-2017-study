using System;

namespace FUP
{
    public class Header : ISerializable
    {
        public uint MSGID { get; set; }//메시지 식별번호
        public uint MSGTYPE { get; set; }//메시지종류
        public uint BODYLEN { get; set; }//메시지 본문 길이
        public byte FRAGMENTED { get; set; }//메시지 분할여부
        public byte LASTMSG { get; set; }//메시지 마지막 여부
        public ushort SEQ { get; set; }//메시지 파편번호

        public Header() { }
        public Header(byte[] bytes)
        {
            MSGID = BitConverter.ToUInt32(bytes, 0);
            MSGTYPE = BitConverter.ToUInt32(bytes, 4);
            BODYLEN = BitConverter.ToUInt32(bytes, 8);
            FRAGMENTED = bytes[12];
            LASTMSG = bytes[13];
            SEQ = BitConverter.ToUInt16(bytes, 14);
        }
        public byte[] GetBytes()
        {
            byte[] bytes = new byte[16];

            byte[] temp = BitConverter.GetBytes(MSGID);
            Array.Copy(temp, 0, bytes, 0, temp.Length);

            temp = BitConverter.GetBytes(MSGTYPE);
            Array.Copy(temp, 0, bytes, 4, temp.Length);

            temp = BitConverter.GetBytes(BODYLEN);
            Array.Copy(temp, 0, bytes, 8, temp.Length);

            bytes[12] = FRAGMENTED;
            bytes[13] = LASTMSG;

            temp = BitConverter.GetBytes(SEQ);
            Array.Copy(temp, 0, bytes, 14, temp.Length);

            return bytes;
        }
        public int GetSize()
        {
            return 16;
        }
    }
}