import javax.swing.JFrame;
import javax.swing.SwingUtilities;


public class EditorTest {
	public static void main(String [] args) {
		SwingUtilities.invokeLater(new Runnable() {
			@Override
			public void run() {
				// TODO Auto-generated method stub
				EditorFrame frame = new EditorFrame();
					frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
			}
		});
		
		
	}
}
