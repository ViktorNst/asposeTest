import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.*;
import static org.junit.jupiter.params.provider.Arguments.arguments;

class StringToKeypadConverterTest {

    private static StringToKeypadConverter stringToKeypadConverter;

    @BeforeAll
    static void beforeAll() {
        stringToKeypadConverter = new StringToKeypadConverter();
    }

    @ParameterizedTest
    @MethodSource("testValuesProvider")
    void convertsString(String input, String result) {
        String s = stringToKeypadConverter.convertToKeyPad(input);
        assertEquals(result, s);
    }

    static Stream<Arguments> testValuesProvider() {
        return Stream.of(
                arguments("hello world", "4433555 555666096667775553"),
                arguments("foo  bar", "333666 6660 022 2777"),
                arguments("yes", "999337777"),
                arguments("hi", "44 444"),
                arguments(" abc ", "02 22 2220")
        );
    }

    @Test
    void skipsUnknownValues() {
        String s = stringToKeypadConverter.convertToKeyPad("Ay*e#s5");
        assertEquals("999337777", s);
    }
}

