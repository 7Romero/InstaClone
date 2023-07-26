"use client";

import Link from "next/link";
import style from "./header.module.scss";
import SignIn from "../UI/buttons/signIn/signIn";
import { useSession } from "next-auth/react";
import SignOut from "../UI/buttons/signOut/signOut";

export default function Header() {
  const { data: session } = useSession();

  return (
    <nav className={"container " + style.navbar}>
      <div className={style.logo}>
        <Link href="/">InstaClone</Link>
      </div>
      <div className={style.links}>
        <Link href="/">Home</Link>
        <Link href="/">Page 1</Link>
        <Link href="/">Page 2</Link>
      </div>
      <div className={style.auth}>{session ? <SignOut /> : <SignIn />}</div>
    </nav>
  );
}
