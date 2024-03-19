function Header(props: any) {
  return (
    <header className="row header navbar navbar-dark bg-dark">
      <div className="col subtitle">
        <h1 className="text-white">{props.title}</h1>
        <p className="text-white">
          The purpose of this site is to display information about different
          bowlers to help us know more about them!
        </p>
      </div>
    </header>
  );
}

export default Header;
