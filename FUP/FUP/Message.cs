//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace FUP
{
    class CONSTANTS
    {
        //메시지 타입 상수로 정의해주고 이걸로 파일전송 요청및 파일전송 구별
        public const uint REQ_FILE_SEND = 0x01;//파일전송 요청
        public const uint REP_FILE_SEND = 0x02;//파일전송 요청응답
        public const uint FILE_SEND_DATA = 0x03;//파일전송
        public const uint FILE_SEND_RES = 0x04;//파일수신 결과
        //메시지 분할여부
        public const byte NOT_FRAGMENTED = 0x00;//미분할
        public const byte FRAGMENTED = 0x01;//분할
        //분할된 메시지 마지막인지 여부
        public const byte NOT_LASTMSG = 0x00;//마지막x
        public const byte LASTMSG = 0x01;//마지막

        public const byte ACCEPTED = 0x01;
        public const byte DENIED = 0x00;

        public const byte FAIL = 0x00;
        public const byte SUCESS = 0x01;
    }

    public interface ISerializable
    {
        byte[] GetBytes();
        int GetSize();
    }
    public class Message : ISerializable
    {
        public Header Header { get; set; }
        public ISerializable Body { get; set; }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];

            Header.GetBytes().CopyTo(bytes, 0);
            Body.GetBytes().CopyTo(bytes, Header.GetSize());
            return bytes;
        }
        public int GetSize()
        {
            return Header.GetSize() + Body.GetSize();
        }
    }
}
