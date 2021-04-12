public enum SymbolEnum {

    A('a', '2', "2"),
    B('b', '2', "22"),
    C('c', '2', "222"),
    D('d', '3', "3"),
    E('e', '3', "33"),
    F('f', '3', "333"),
    G('g', '4', "4"),
    H('h', '4', "44"),
    I('i', '4', "444"),
    J('j', '5', "5"),
    K('k', '5', "55"),
    L('l', '5', "555"),
    M('m', '6', "6"),
    N('n', '6', "66"),
    O('o', '6', "666"),
    P('p', '7', "7"),
    Q('q', '7', "77"),
    R('r', '7', "777"),
    S('s', '7', "7777"),
    T('t', '8', "8"),
    U('u', '8', "88"),
    V('v', '8', "888"),
    W('w', '9', "9"),
    X('x', '9', "99"),
    Y('y', '9', "999"),
    Z('z', '9', "9999"),
    SPACE(' ', '0', "0");

    public static SymbolEnum[] enumArray = new SymbolEnum[128];

    static {
        for (SymbolEnum value : values()) {
            enumArray[value.chr] = value;
        }
    }

    public final char chr;
    public final char key;
    public final String keySequence;

    SymbolEnum(char chr, char key, String keySequence) {
        this.chr = chr;
        this.key = key;
        this.keySequence = keySequence;
    }

    public static SymbolEnum getByChar(char chr) {
        if (chr >= 128) {
            return null;
        }
        return enumArray[chr];
    }
}
