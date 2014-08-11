"""LCM type definitions
This file automatically generated by lcm.
DO NOT MODIFY BY HAND!!!!
"""

import cStringIO as StringIO
import struct

import header

class piemos_health(object):
    __slots__ = ["header", "auton", "enabled", "robot_connection", "xbox_controller", "game_time"]

    def __init__(self):
        self.header = None
        self.auton = False
        self.enabled = False
        self.robot_connection = False
        self.xbox_controller = False
        self.game_time = 0

    def encode(self):
        buf = StringIO.StringIO()
        buf.write(piemos_health._get_packed_fingerprint())
        self._encode_one(buf)
        return buf.getvalue()

    def _encode_one(self, buf):
        assert self.header._get_packed_fingerprint() == header.header._get_packed_fingerprint()
        self.header._encode_one(buf)
        buf.write(struct.pack(">bbbbi", self.auton, self.enabled, self.robot_connection, self.xbox_controller, self.game_time))

    def decode(data):
        if hasattr(data, 'read'):
            buf = data
        else:
            buf = StringIO.StringIO(data)
        if buf.read(8) != piemos_health._get_packed_fingerprint():
            raise ValueError("Decode error")
        return piemos_health._decode_one(buf)
    decode = staticmethod(decode)

    def _decode_one(buf):
        self = piemos_health()
        self.header = header.header._decode_one(buf)
        self.auton, self.enabled, self.robot_connection, self.xbox_controller, self.game_time = struct.unpack(">bbbbi", buf.read(8))
        return self
    _decode_one = staticmethod(_decode_one)

    _hash = None
    def _get_hash_recursive(parents):
        if piemos_health in parents: return 0
        newparents = parents + [piemos_health]
        tmphash = (0x684c6c42b9e14cf1+ header.header._get_hash_recursive(newparents)) & 0xffffffffffffffff
        tmphash  = (((tmphash<<1)&0xffffffffffffffff)  + (tmphash>>63)) & 0xffffffffffffffff
        return tmphash
    _get_hash_recursive = staticmethod(_get_hash_recursive)
    _packed_fingerprint = None

    def _get_packed_fingerprint():
        if piemos_health._packed_fingerprint is None:
            piemos_health._packed_fingerprint = struct.pack(">Q", piemos_health._get_hash_recursive([]))
        return piemos_health._packed_fingerprint
    _get_packed_fingerprint = staticmethod(_get_packed_fingerprint)

