import type { Metadata } from "next";
import Header from "@/components/header/header";
import Footer from "@/components/footer/footer";
import "./styles/global.scss";
import styles from "./styles/layout.module.scss";
import Providers from "@/components/providers/Providers";

export const metadata: Metadata = {
  title: "Insta Clone",
};

export default function RootLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  return (
    <html lang="en">
      <body className={styles.app}>
        <Providers>
          <header className={styles.header}>
            <Header />
          </header>
          <main className={styles.main}>{children}</main>
          <footer className={styles.footer}>
            <Footer />
          </footer>
        </Providers>
      </body>
    </html>
  );
}
