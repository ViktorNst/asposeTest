import java.util.ArrayList;
import java.util.Scanner;

public class Application {

    public static void main(String[] args) {
        StringToKeypadConverter converter = new StringToKeypadConverter();
        ArrayList<String> strings = new ArrayList<>();

        Scanner in = new Scanner(System.in);
        int count = in.nextInt();
        in.nextLine();
        for (int i = 0; i < count; i++) {
            strings.add(in.nextLine());
        }

        int i = 0;
        for (String string : strings) {
            i++;
            System.out.println("Case #" + i + ": " + converter.convertToKeyPad(string));
        }
    }
}
