public class StringToKeypadConverter {

    public String convertToKeyPad(String input) {
        StringBuilder stringBuilder = new StringBuilder();
        SymbolEnum previousSymbol = null;
        for (int i = 0; i < input.length(); i++) {
            char inputChar = input.charAt(i);
            SymbolEnum symbol = SymbolEnum.getByChar(inputChar);
            if (previousSymbol != null && symbol != null && symbol.key == previousSymbol.key) {
                stringBuilder.append(" ");
            }
            if (symbol != null) {
                stringBuilder.append(symbol.keySequence);
            }
            previousSymbol = symbol;
        }
        return stringBuilder.toString();
    }

}
